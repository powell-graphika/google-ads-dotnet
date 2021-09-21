using NUnit.Framework;

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Util;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;


using Google.Ads.GoogleAds.V8.Errors;
using Google.Ads.GoogleAds.V8.Services;
using Google.Ads.GoogleAds.V8.Resources;
using Google.Ads.GoogleAds.V8.Common;

using static Google.Ads.GoogleAds.V8.Enums.AgeRangeTypeEnum.Types;
using static Google.Ads.GoogleAds.V8.Enums.GenderTypeEnum.Types;

using static Google.Ads.GoogleAds.V8.Enums.AdGroupCriterionStatusEnum.Types;
using static Google.Ads.GoogleAds.V8.Enums.KeywordMatchTypeEnum.Types;
using static Google.Ads.GoogleAds.V8.Enums.KeywordPlanNetworkEnum.Types;
using static Google.Ads.GoogleAds.V8.Enums.ProximityRadiusUnitsEnum.Types;

using Microsoft.Data.Analysis;
using Google.Ads.GoogleAds;
using static Google.Ads.GoogleAds.V8.Enums.BudgetDeliveryMethodEnum.Types;
using static Google.Ads.GoogleAds.V8.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V8.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V8.Resources.Campaign.Types;

namespace Google_API_Connection
{
    public class Tests
    {
        //Test account:
        public static long customerId = 2666127839;

        //MPP account:
        //public static long customerId = 5915991725;  //Gino's Pizza
        //public static long customerId = 1865445919;  //Pizza Al Forno

        private static string CreateBudget(GoogleAdsClient client, long customerId, int rand)
        {
            // Get the BudgetService.
            CampaignBudgetServiceClient budgetService = client.GetService(
                Services.V8.CampaignBudgetService);

            // Create the campaign budget.
            CampaignBudget budget = new CampaignBudget()
            {
                Name = "Test Budget #" + rand.ToString(),
                DeliveryMethod = BudgetDeliveryMethod.Standard,
                AmountMicros = 50000
            };

            // Create the operation.
            CampaignBudgetOperation budgetOperation = new CampaignBudgetOperation()
            {
                Create = budget
            };

            // Create the campaign budget.
            MutateCampaignBudgetsResponse response = budgetService.MutateCampaignBudgets(
                customerId.ToString(), new CampaignBudgetOperation[] { budgetOperation });
            return response.Results[0].ResourceName;
        }

        public static void CreateCampaign(long customerId)
        {
            GoogleAdsClient client = new GoogleAdsClient();
            int NUM_CAMPAIGNS_TO_CREATE = 1;
            var rand = new Random();
            var randNum = rand.Next();

            // Get the CampaignService.
            CampaignServiceClient campaignService = client.GetService(Services.V8.CampaignService);

            // Create a budget to be used for the campaign.
            string budget = CreateBudget(client, customerId, randNum);

            List<CampaignOperation> operations = new List<CampaignOperation>();

            for (int i = 0; i < NUM_CAMPAIGNS_TO_CREATE; i++)
            {
                // [START add_campaigns_1]
                // Create the campaign.
                Campaign campaign = new Campaign()
                {
                    Name = "Test Campaign #" + randNum.ToString(),
                    AdvertisingChannelType = AdvertisingChannelType.Search,

                    // Recommendation: Set the campaign to PAUSED when creating it to prevent
                    // the ads from immediately serving. Set to ENABLED once you've added
                    // targeting and the ads are ready to serve
                    Status = CampaignStatus.Paused,

                    // Set the bidding strategy and budget.
                    ManualCpc = new ManualCpc(),
                    CampaignBudget = budget,

                    // Set the campaign network options.
                    NetworkSettings = new NetworkSettings
                    {
                        TargetGoogleSearch = true,
                        TargetSearchNetwork = true,
                        TargetContentNetwork = false,
                        TargetPartnerSearchNetwork = false
                    },

                    // Optional: Set the start date.
                    StartDate = DateTime.Now.AddDays(1).ToString("yyyyMMdd"),

                    // Optional: Set the end date.
                    EndDate = DateTime.Now.AddYears(1).ToString("yyyyMMdd"),
                };
                // [END add_campaigns_1]

                // Create the operation.
                operations.Add(new CampaignOperation() { Create = campaign });
            }
            try
            {
                // Add the campaigns.
                MutateCampaignsResponse retVal = campaignService.MutateCampaigns(
                    customerId.ToString(), operations);

                // Display the results.
                if (retVal.Results.Count > 0)
                {
                    foreach (MutateCampaignResult newCampaign in retVal.Results)
                    {
                        Console.WriteLine("Campaign with resource ID = '{0}' was added.",
                            newCampaign.ResourceName);
                    }
                }
                else
                {
                    Console.WriteLine("No campaigns were added.");
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        public static void PauseCampaign(long customerId, long campaignId)
        {
            GoogleAdsClient client = new GoogleAdsClient();

            // Get the GoogleAdsService.
            CampaignServiceClient campaignService = client.GetService(
                Services.V8.CampaignService);

            // Create the campaign.
            Campaign campaign = new Campaign
            {
                ResourceName = ResourceNames.Campaign(customerId, campaignId),
                Status = Google.Ads.GoogleAds.V8.Enums.CampaignStatusEnum.Types.CampaignStatus.Paused
            };

            // Create the operation.
            CampaignOperation operation = new CampaignOperation
            {
                // Set the Update field to the ad group ad object.
                Update = campaign,

                // Use the FieldMasks utility to set the UpdateMask field to  a list of all
                // modified fields of the ad group ad.
                UpdateMask = FieldMasks.AllSetFieldsOf(campaign)
            };
            try
            {
                // Update the ad.
                MutateCampaignsResponse response =
                    campaignService.MutateCampaigns(customerId.ToString(),
                        new CampaignOperation[] { operation });

                // Display the results.
                foreach (MutateCampaignResult result in response.Results)
                {
                    Console.WriteLine($"campaign with resource name = {result.ResourceName} was " +
                        "paused.");
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        public static void PauseAdGroup(long customerId, long adGroupId)
        {
            GoogleAdsClient client = new GoogleAdsClient();

            // Get the GoogleAdsService.
            AdGroupServiceClient adGroupService = client.GetService(
                Services.V8.AdGroupService);

            // Create the adGroup.
            AdGroup adGroup = new AdGroup
            {
                ResourceName = ResourceNames.AdGroup(customerId, adGroupId),
                Status = Google.Ads.GoogleAds.V8.Enums.AdGroupStatusEnum.Types.AdGroupStatus.Paused
            };

            // Create the operation.
            AdGroupOperation operation = new AdGroupOperation
            {
                // Set the Update field to the ad group ad object.
                Update = adGroup,

                // Use the FieldMasks utility to set the UpdateMask field to  a list of all
                // modified fields of the ad group ad.
                UpdateMask = FieldMasks.AllSetFieldsOf(adGroup)
            };
            try
            {
                // Update the ad.
                MutateAdGroupsResponse response =
                    adGroupService.MutateAdGroups(customerId.ToString(),
                        new AdGroupOperation[] { operation });

                // Display the results.
                foreach (MutateAdGroupResult result in response.Results)
                {
                    Console.WriteLine($"adGroup with resource name = {result.ResourceName} was " +
                        "paused.");
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        public static void PauseAdGroupAd(long customerId, long adGroupId, long adGroupAdId)
        {
            GoogleAdsClient client = new GoogleAdsClient();

            // Get the Service.
            AdGroupAdServiceClient adGroupAdService = client.GetService(
                Services.V8.AdGroupAdService);

            // Create the adGroupAd.
            AdGroupAd adGroupAd = new AdGroupAd
            {
                ResourceName = ResourceNames.AdGroupAd(customerId, adGroupId, adGroupAdId),
                Status = Google.Ads.GoogleAds.V8.Enums.AdGroupAdStatusEnum.Types.AdGroupAdStatus.Paused
            };

            // Create the operation.
            AdGroupAdOperation operation = new AdGroupAdOperation
            {
                // Set the Update field to the ad group ad object.
                Update = adGroupAd,

                // Use the FieldMasks utility to set the UpdateMask field to  a list of all
                // modified fields of the ad group ad.
                UpdateMask = FieldMasks.AllSetFieldsOf(adGroupAd)
            };
            try
            {
                // Update the ad.
                MutateAdGroupAdsResponse response =
                    adGroupAdService.MutateAdGroupAds(customerId.ToString(),
                        new AdGroupAdOperation[] { operation });

                // Display the results.
                foreach (MutateAdGroupAdResult result in response.Results)
                {
                    Console.WriteLine($"AdGroup Ad with resource name = {result.ResourceName} was " +
                        "paused.");
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }


        public static void EnableCampaign(long customerId, long campaignId)
        {
            GoogleAdsClient client = new GoogleAdsClient();

            // Get the GoogleAdsService.
            CampaignServiceClient campaignService = client.GetService(
                Services.V8.CampaignService);

            // Create the campaign.
            Campaign campaign = new Campaign
            {
                ResourceName = ResourceNames.Campaign(customerId, campaignId),
                Status = Google.Ads.GoogleAds.V8.Enums.CampaignStatusEnum.Types.CampaignStatus.Enabled
            };

            // Create the operation.
            CampaignOperation operation = new CampaignOperation
            {
                // Set the Update field to the ad group ad object.
                Update = campaign,

                // Use the FieldMasks utility to set the UpdateMask field to  a list of all
                // modified fields of the ad group ad.
                UpdateMask = FieldMasks.AllSetFieldsOf(campaign)
            };
            try
            {
                // Update the ad.
                MutateCampaignsResponse response =
                    campaignService.MutateCampaigns(customerId.ToString(),
                        new CampaignOperation[] { operation });

                // Display the results.
                foreach (MutateCampaignResult result in response.Results)
                {
                    Console.WriteLine($"campaign with resource name = {result.ResourceName} was " +
                        "ENABLED.");
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        public static void EnableAdGroup(long customerId, long adGroupId)
        {
            GoogleAdsClient client = new GoogleAdsClient();

            // Get the GoogleAdsService.
            AdGroupServiceClient adGroupService = client.GetService(
                Services.V8.AdGroupService);

            // Create the adGroup.
            AdGroup adGroup = new AdGroup
            {
                ResourceName = ResourceNames.AdGroup(customerId, adGroupId),
                Status = Google.Ads.GoogleAds.V8.Enums.AdGroupStatusEnum.Types.AdGroupStatus.Enabled
            };

            // Create the operation.
            AdGroupOperation operation = new AdGroupOperation
            {
                // Set the Update field to the ad group ad object.
                Update = adGroup,

                // Use the FieldMasks utility to set the UpdateMask field to  a list of all
                // modified fields of the ad group ad.
                UpdateMask = FieldMasks.AllSetFieldsOf(adGroup)
            };
            try
            {
                // Update the ad.
                MutateAdGroupsResponse response =
                    adGroupService.MutateAdGroups(customerId.ToString(),
                        new AdGroupOperation[] { operation });

                // Display the results.
                foreach (MutateAdGroupResult result in response.Results)
                {
                    Console.WriteLine($"adGroup with resource name = {result.ResourceName} was " +
                        "ENABLED.");
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        public static void EnableAdGroupAd(long customerId, long adGroupId, long adGroupAdId)
        {
            GoogleAdsClient client = new GoogleAdsClient();

            // Get the GoogleAdsService.
            AdGroupAdServiceClient adGroupAdService = client.GetService(
                Services.V8.AdGroupAdService);

            // Create the adGroupAd.
            AdGroupAd adGroupAd = new AdGroupAd
            {
                ResourceName = ResourceNames.AdGroupAd(customerId, adGroupId, adGroupAdId),
                Status = Google.Ads.GoogleAds.V8.Enums.AdGroupAdStatusEnum.Types.AdGroupAdStatus.Enabled
            };

            // Create the operation.
            AdGroupAdOperation operation = new AdGroupAdOperation
            {
                // Set the Update field to the ad group ad object.
                Update = adGroupAd,

                // Use the FieldMasks utility to set the UpdateMask field to  a list of all
                // modified fields of the ad group ad.
                UpdateMask = FieldMasks.AllSetFieldsOf(adGroupAd)
            };
            try
            {
                // Update the ad.
                MutateAdGroupAdsResponse response =
                    adGroupAdService.MutateAdGroupAds(customerId.ToString(),
                        new AdGroupAdOperation[] { operation });

                // Display the results.
                foreach (MutateAdGroupAdResult result in response.Results)
                {
                    Console.WriteLine($"adGroupAd with resource name = {result.ResourceName} was " +
                        "ENABLED.");
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }


        public static void ListCampaignInfoStats(long customerId)
        {
            GoogleAdsClient googleAdsClient = new GoogleAdsClient();

            GoogleAdsClient client = new GoogleAdsClient();

            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V8.GoogleAdsService);

            // Create a query that will retrieve all campaigns.
            // pchu: for more information on query, please visit;
            // https://developers.google.com/google-ads/api/docs/reporting/criteria-metrics

            /* 
             * 
             * cost_micros: The sum of your cost-per-click (CPC) and cost-per-thousand impressions (CPM) costs during this period.
             * average_cost: The average amount you pay per interaction. This amount is the total cost of your ads divided by the total number of interactions.
             * average_cpc: The total cost of all clicks divided by the total number of clicks received.
             * average_cpm: Average cost-per-thousand impressions (CPM).
             * bounce_rate: Percentage of clicks where the user only visited a single page on your site. Imported from Google Analytics.
             */

            /*
                 ad_group_ad.ad.id,
                 ad_group_ad.status,
            */

            string query2 =
                @"SELECT
                 campaign.id,
                 campaign.name,
                 campaign.status,
                 ad_group.id,
                 ad_group.name,
                 ad_group.status,
                 metrics.clicks,
                 metrics.conversions,
                 metrics.impressions,
                 metrics.engagements,
                 metrics.interactions,
                 metrics.cost_micros,
                 metrics.average_cost,
                 metrics.average_cpc,
                 metrics.average_cpm,
                 metrics.bounce_rate
            FROM ad_group
            WHERE segments.date DURING TODAY
            ";

            try
            {
                // Issue a search request.
                googleAdsService.SearchStream(customerId.ToString(), query2,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        foreach (GoogleAdsRow dataRow in resp.Results)
                        {
                            // /*
                            Console.WriteLine(
                                $"Campaign ID: {dataRow.Campaign.Id}\nCampaign name: {dataRow.Campaign.Name}\n" +
                                $"Campaign Status: {dataRow.Campaign.Status}\n" +
                                $"Ad Group ID: {dataRow.AdGroup.Id}\nAd Group name: {dataRow.AdGroup.Name}\n" +
                                $"Ad Group Status: {dataRow.AdGroup.Status}\n" +
                                $"Clicks: {dataRow.Metrics.Clicks}\n" +
                                $"Conversions: {dataRow.Metrics.Conversions}\nImpressions: {dataRow.Metrics.Impressions}\n" +
                                $"Engagements: {dataRow.Metrics.Engagements}\nInteractions: {dataRow.Metrics.Interactions}\n" +
                                $"Cost micros: {dataRow.Metrics.CostMicros}\nAverage Cost: {dataRow.Metrics.AverageCost}\n" +
                                $"Average CPC: {dataRow.Metrics.AverageCpc}\nAverage CPM: {dataRow.Metrics.AverageCpm}\n" +
                                $"Bounce Rate: {dataRow.Metrics.BounceRate}\n\n"
                                );
                            // */
                        }
                    }
                );
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        public static void ListAdGroupAdInfoStats(long customerId)
        {
            GoogleAdsClient googleAdsClient = new GoogleAdsClient();

            GoogleAdsClient client = new GoogleAdsClient();

            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V8.GoogleAdsService);

            string query =
                @"SELECT
                 campaign.id,
                 campaign.name,
                 campaign.status,
                 ad_group.id,
                 ad_group.name,
                 ad_group.status,
                 ad_group_ad.ad.id,
                 ad_group_ad.ad.name,
                 ad_group_ad.status,
                 metrics.clicks,
                 metrics.conversions,
                 metrics.impressions,
                 metrics.engagements,
                 metrics.interactions,
                 metrics.cost_micros,
                 metrics.average_cost,
                 metrics.average_cpc,
                 metrics.average_cpm,
                 metrics.bounce_rate
            FROM ad_group_ad
            WHERE segments.date DURING TODAY
            ";

            try
            {
                // Issue a search request.
                googleAdsService.SearchStream(customerId.ToString(), query,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        foreach (GoogleAdsRow dataRow in resp.Results)
                        {
                            // /*
                            Console.WriteLine(
                                $"Campaign ID: {dataRow.Campaign.Id}\nCampaign name: {dataRow.Campaign.Name}\n" +
                                $"Campaign Status: {dataRow.Campaign.Status}\n" +
                                $"Ad Group ID: {dataRow.AdGroup.Id}\nAd Group name: {dataRow.AdGroup.Name}\n" +
                                $"Ad Group Status: {dataRow.AdGroup.Status}\n" +
                                $"Ad ID: {dataRow.AdGroupAd.Ad.Id}\nAd name: {dataRow.AdGroupAd.Ad.Name}\n" +
                                $"Ad Status: {dataRow.AdGroupAd.Status}\n" +
                                $"Clicks: {dataRow.Metrics.Clicks}\n" +
                                $"Conversions: {dataRow.Metrics.Conversions}\nImpressions: {dataRow.Metrics.Impressions}\n" +
                                $"Engagements: {dataRow.Metrics.Engagements}\nInteractions: {dataRow.Metrics.Interactions}\n" +
                                $"Cost micros: {dataRow.Metrics.CostMicros}\nAverage Cost: {dataRow.Metrics.AverageCost}\n" +
                                $"Average CPC: {dataRow.Metrics.AverageCpc}\nAverage CPM: {dataRow.Metrics.AverageCpm}\n" +
                                $"Bounce Rate: {dataRow.Metrics.BounceRate}\n\n"
                                );
                            // */
                        }
                    }
                );
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }


        //PCHU: JUNE21 --> WORKING
        public static void GetAdGroupAdInfo(long customerId, long adGroupAdId)
        {
            GoogleAdsClient googleAdsClient = new GoogleAdsClient();

            GoogleAdsClient client = new GoogleAdsClient();

            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V8.GoogleAdsService);


            string query =
                $@"SELECT
                 campaign.id,
                 campaign.name,
                 campaign.status,
                 ad_group.id,
                 ad_group.name,
                 ad_group.status,
                 ad_group_ad.ad.id,
                 ad_group_ad.ad.name,
                 ad_group_ad.status,
                 metrics.clicks,
                 metrics.conversions,
                 metrics.impressions,
                 metrics.engagements,
                 metrics.interactions,
                 metrics.cost_micros,
                 metrics.average_cost,
                 metrics.average_cpc,
                 metrics.average_cpm,
                 metrics.bounce_rate
            FROM ad_group
            WHERE ad_group.id = {adGroupAdId}
            ";

            try
            {
                // Issue a search request.
                googleAdsService.SearchStream(customerId.ToString(), query,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        foreach (GoogleAdsRow dataRow in resp.Results)
                        {
                            // /*
                            Console.WriteLine(
                                $"Campaign ID: {dataRow.Campaign.Id}\nCampaign name: {dataRow.Campaign.Name}\n" +
                                $"Ad Group ID: {dataRow.AdGroup.Id}\nAd Group name: {dataRow.AdGroup.Name}\n" +
                                //$"Ad ID: {dataRow.AdGroupAd.Ad.Id}\nAd status: {dataRow.AdGroupAd.Status}\n" +
                                $"Clicks: {dataRow.Metrics.Clicks}\n" +
                                $"Conversions: {dataRow.Metrics.Conversions}\nImpressions: {dataRow.Metrics.Impressions}\n" +
                                $"Engagements: {dataRow.Metrics.Engagements}\nInteractions: {dataRow.Metrics.Interactions}\n" +
                                $"Cost micros: {dataRow.Metrics.CostMicros}\nAverage Cost: {dataRow.Metrics.AverageCost}\n" +
                                $"Average CPC: {dataRow.Metrics.AverageCpc}\nAverage CPM: {dataRow.Metrics.AverageCpm}\n" +
                                $"Bounce Rate: {dataRow.Metrics.BounceRate}\n\n"
                                );
                            // */
                        }
                    }
                );
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        public static void GetAdGroupCriteria(long customerId, long adGroupId)
        {
            GoogleAdsClient googleAdsClient = new GoogleAdsClient();

            GoogleAdsClient client = new GoogleAdsClient();

            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V8.GoogleAdsService);


            string query =
                $@"SELECT
                 campaign.id,
                 campaign.name,
                 campaign.status,
                 ad_group.id,
                 ad_group.name,
                 ad_group.status,
                 ad_group_criterion.criterion_id,
                 ad_group_criterion.display_name,
                 ad_group_criterion.status,
                 ad_group_criterion.keyword.text

            FROM ad_group_criterion
            WHERE ad_group.id = {adGroupId}
            ";

            try
            {
                // Issue a search request.
                googleAdsService.SearchStream(customerId.ToString(), query,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        foreach (GoogleAdsRow dataRow in resp.Results)
                        {
                            // /*
                            Console.WriteLine(
                                $"Campaign ID: {dataRow.Campaign.Id}\nCampaign name: {dataRow.Campaign.Name}\n" +
                                $"Campaign Status: {dataRow.Campaign.Status}\n" +
                                $"Ad Group ID: {dataRow.AdGroup.Id}\nAd Group name: {dataRow.AdGroup.Name}\n" +
                                $"Ad Group Status: {dataRow.AdGroup.Status}\n" +
                                $"Ad Group Criterion ID: {dataRow.AdGroupCriterion.CriterionId}\n" +
                                $"Ad Group Criterion Display Name: {dataRow.AdGroupCriterion.DisplayName}\n" +
                                $"Ad Group Criterion Status: {dataRow.AdGroupCriterion.Status}\n" +
                                $"Ad Group Keyword: {dataRow.AdGroupCriterion.Keyword?.Text}\n"
                                );
                            // */
                        }
                    }
                );
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }


        //pchu working on this now June 21st
        public static void getAgeRangeInfo(long customerId, long campaignId, long adGroupId = 0)
        {
            GoogleAdsClient googleAdsClient = new GoogleAdsClient();

            GoogleAdsClient client = new GoogleAdsClient();

            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V8.GoogleAdsService);


            string query100 = $@"SELECT 
                ad_group_criterion.age_range.type,
                campaign.name,
                campaign.id,
                campaign.status,
                ad_group.name,
                ad_group.id,
                ad_group.status,
                ad_group_criterion.system_serving_status,
                ad_group_criterion.bid_modifier
            FROM ad_group_criterion
            WHERE ad_group.id = {adGroupId}
            ORDER BY ad_group.name
            ";
            //            FROM age_range_view
            //            WHERE segments.date DURING TODAY
            //            WHERE campaign.id = '12429579081';

            try
            {
                // Issue a search request.
                googleAdsService.SearchStream(customerId.ToString(), query100,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        foreach (GoogleAdsRow dataRow in resp.Results)
                        {
                            // /*
                            Console.WriteLine(
                                $"Campaign ID: {dataRow.Campaign.Id}\n Campaign Name: {dataRow.Campaign.Name}\n" +
                                $"Campaign Status: {dataRow.Campaign.Status}\n" +
                                $"AdGroup ID: {dataRow.AdGroup.Id}\n AdGroup Name: {dataRow.AdGroup.Name}\n" +
                                $"AdGroup Status: {dataRow.AdGroup.Status}\n" +
                                $"System Servicing Status: {dataRow.AdGroupCriterion.SystemServingStatus}\n" +
                                $"bid modifier: {dataRow.AdGroupCriterion.BidModifier}\n" +
                                $"Age Range Type: {dataRow.AdGroupCriterion.AgeRange?.Type}\n"
                                //$"Ad ID: {dataRow.AdGroupAd.Ad.Id}\nAd status: {dataRow.AdGroupAd.Status}\n" +
                                //$"Clicks: {dataRow.Metrics.Clicks}\n" +
                                //$"Conversions: {dataRow.Metrics.Conversions}\nImpressions: {dataRow.Metrics.Impressions}\n" +
                                //$"Engagements: {dataRow.Metrics.Engagements}\nInteractions: {dataRow.Metrics.Interactions}\n" +
                                //$"Cost micros: {dataRow.Metrics.CostMicros}\nAverage Cost: {dataRow.Metrics.AverageCost}\n" +
                                //$"Average CPC: {dataRow.Metrics.AverageCpc}\nAverage CPM: {dataRow.Metrics.AverageCpm}\n" +
                                //$"Bounce Rate: {dataRow.Metrics.BounceRate}\n\n"
                                );
                            // */
                        }
                    }
                );
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }


        public static void getAdGroupAdInfo(long customerId)
        {
            GoogleAdsClient googleAdsClient = new GoogleAdsClient();

            GoogleAdsClient client = new GoogleAdsClient();

            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V8.GoogleAdsService);

            // Create a query that will retrieve all campaigns.
            // pchu: for more information on query, please visit;
            // https://developers.google.com/google-ads/api/docs/reporting/criteria-metrics

            /* 
             * 
             * cost_micros: The sum of your cost-per-click (CPC) and cost-per-thousand impressions (CPM) costs during this period.
             * average_cost: The average amount you pay per interaction. This amount is the total cost of your ads divided by the total number of interactions.
             * average_cpc: The total cost of all clicks divided by the total number of clicks received.
             * average_cpm: Average cost-per-thousand impressions (CPM).
             * bounce_rate: Percentage of clicks where the user only visited a single page on your site. Imported from Google Analytics.
             */

            string query =
                @"SELECT
                 campaign.id,
                 campaign.name,
                 ad_group.id,
                 ad_group.name,
                 ad_group_ad.ad.id,
                 ad_group_ad.status,
                 metrics.clicks,
                 metrics.conversions,
                 metrics.impressions,
                 metrics.engagements,
                 metrics.interactions,
                 metrics.cost_micros,
                 metrics.average_cost,
                 metrics.average_cpc,
                 metrics.average_cpm,
                 metrics.bounce_rate
            FROM ad_group_ad
            WHERE segments.date DURING TODAY
            ";

            try
            {
                // Issue a search request.
                googleAdsService.SearchStream(customerId.ToString(), query,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        foreach (GoogleAdsRow dataRow in resp.Results)
                        {
                            // /*
                            Console.WriteLine(
                                $"Campaign ID: {dataRow.Campaign.Id}\nCampaign name: {dataRow.Campaign.Name}\n" +
                                $"Ad Group ID: {dataRow.AdGroup.Id}\nAd Group name: {dataRow.AdGroup.Name}\n" +
                                $"Ad ID: {dataRow.AdGroupAd.Ad.Id}\nAd status: {dataRow.AdGroupAd.Status}\n" +
                                $"Clicks: {dataRow.Metrics.Clicks}\n" +
                                $"Conversions: {dataRow.Metrics.Conversions}\nImpressions: {dataRow.Metrics.Impressions}\n" +
                                $"Engagements: {dataRow.Metrics.Engagements}\nInteractions: {dataRow.Metrics.Interactions}\n" +
                                $"Cost micros: {dataRow.Metrics.CostMicros}\nAverage Cost: {dataRow.Metrics.AverageCost}\n" +
                                $"Average CPC: {dataRow.Metrics.AverageCpc}\nAverage CPM: {dataRow.Metrics.AverageCpm}\n" +
                                $"Bounce Rate: {dataRow.Metrics.BounceRate}\n\n"
                                );
                            // */
                        }
                    }
                );
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        public static void getCampaignKeywordsInfo(long customerId)
        {
            GoogleAdsClient googleAdsClient = new GoogleAdsClient();

            GoogleAdsClient client = new GoogleAdsClient();

            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V8.GoogleAdsService);

            // Create a query that will retrieve all campaigns.
            // pchu: for more information on query, please visit;
            // https://developers.google.com/google-ads/api/docs/reporting/criteria-metrics

            /*
                            ad_group.id,
                            ad_group.name,
                            ad_group_criterion.keyword.text,
                            metrics.ctr,
                            metrics.average_cpc
                            campaign.network_settings.target_content_network

            string query = @"SELECT
                            campaign.id,
                            campaign.name,
                            campaign.start_date,
                            campaign.status,
                            metrics.bounce_rate,
                            metrics.clicks,
                            metrics.impressions,
                            metrics.ctr
                        FROM campaign
                        WHERE segments.date = '2021-03-10'";
            //ORDER BY campaign.id";
            */
            /* clicks,conversions,frequency,cpc,cpm,website_purchase_roas,purchase_roas,reach,impressions,spend,objective
             * 
             * cost_micros: The sum of your cost-per-click (CPC) and cost-per-thousand impressions (CPM) costs during this period.
             * average_cost: The average amount you pay per interaction. This amount is the total cost of your ads divided by the total number of interactions.
             * average_cpc: The total cost of all clicks divided by the total number of clicks received.
             * average_cpm: Average cost-per-thousand impressions (CPM).
             * bounce_rate: Percentage of clicks where the user only visited a single page on your site. Imported from Google Analytics.
             */
            /*
            string query1 =
                @"SELECT
                 campaign.id,
                 campaign.name,
                 ad_group.id,
                 ad_group.name,
                 ad_group_criterion.criterion_id,
                 ad_group_criterion.keyword.text,
                 ad_group_criterion.keyword.match_type,
                 metrics.clicks,
                 metrics.conversions,
                 metrics.impressions,
                 metrics.cost_micros,
                 metrics.average_cost,
                 metrics.average_cpc,
                 metrics.average_cpm,
                 metrics.bounce_rate,
                 metrics.interactions
             FROM keyword_view
             WHERE segments.date DURING LAST_7_DAYS
                 AND ad_group.status = 'ENABLED'
                 AND ad_group_criterion.status IN ('ENABLED','PAUSED')
             ";
            */

            /* Keyword_view: https://developers.google.com/google-ads/api/fields/V8/keyword_view
             */

            string query2 =
                $@"SELECT
                    ad_group.id,
                    ad_group.status,
                    ad_group_criterion.criterion_id,
                    ad_group_criterion.keyword.text,
                    ad_group_criterion.keyword.match_type,

                 campaign.id,
                 campaign.name,
                 metrics.clicks,
                 metrics.conversions,
                 metrics.impressions,
                 metrics.engagements,
                 metrics.interactions,
                 metrics.cost_micros,
                 metrics.average_cost,
                 metrics.average_cpc,
                 metrics.average_cpm,
                 metrics.bounce_rate
            FROM keyword_view
            WHERE segments.date DURING TODAY
            ";

            try
            {
                // Issue a search request.

                /*
                googleAdsService.SearchStream(customerId.ToString(), query1,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        foreach (GoogleAdsRow criterionRow in resp.Results)
                        {
                            Console.WriteLine(
                                "Keyword with text " +
                                $"'{criterionRow.AdGroupCriterion.Keyword.Text}', match type " +
                                $"'{criterionRow.AdGroupCriterion.Keyword.MatchType}' and ID " +
                                $"{criterionRow.AdGroupCriterion.CriterionId} in ad group " +
                                $"'{criterionRow.AdGroup.Name}' with ID " +
                                $"{criterionRow.AdGroup.Id} in campaign " +
                                $"'{criterionRow.Campaign.Name}' with ID " +
                                $"{criterionRow.Campaign.Id} had " +
                                $"{criterionRow.Metrics.Impressions.ToString()} impressions, " +
                                $"{criterionRow.Metrics.Clicks} clicks, and " +
                                $"{criterionRow.Metrics.CostMicros} cost (in micros) during the " +
                                "last 7 days. \n\n");
                        }
                    }
                );
                */

                googleAdsService.SearchStream(customerId.ToString(), query2,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        foreach (GoogleAdsRow dataRow in resp.Results)
                        {
                            // /*
                            Console.WriteLine(
                                $"Resource Name: {dataRow.KeywordView.ResourceName}\n" +
                                $"Keyword: '{dataRow.AdGroupCriterion.Keyword.Text}'\n" +
                                $"Campaign ID: {dataRow.Campaign.Id}\nCampaign name: {dataRow.Campaign.Name}\n" /*+
                                $"Ad Group ID: {dataRow.AdGroup.Id}\nAd Group name: {dataRow.AdGroup.Name}\n" +
                                $"Clicks: {dataRow.Metrics.Clicks}\n" +
                                $"Conversions: {dataRow.Metrics.Conversions}\nImpressions: {dataRow.Metrics.Impressions}\n" +
                                $"Engagements: {dataRow.Metrics.Engagements}\nInteractions: {dataRow.Metrics.Interactions}\n" +
                                $"Cost micros: {dataRow.Metrics.CostMicros}\nAverage Cost: {dataRow.Metrics.AverageCost}\n" +
                                $"Average CPC: {dataRow.Metrics.AverageCpc}\nAverage CPM: {dataRow.Metrics.AverageCpm}\n" +
                                $"Bounce Rate: {dataRow.Metrics.BounceRate}\n\n"*/
                                );
                            // */
                        }
                    }
                );
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }
        public static void getGeoTarget(long customerId, long campaignId)
        {
            GoogleAdsClient googleAdsClient = new GoogleAdsClient();

            GoogleAdsClient client = new GoogleAdsClient();

            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V8.GoogleAdsService);

            // Create a query that will retrieve all campaigns.
            // pchu: for more information on query, please visit;
            // https://developers.google.com/google-ads/api/docs/targeting/location-targeting#c

            string query =
                $@"SELECT
                  campaign_criterion.campaign,
                  campaign_criterion.criterion_id,
                  campaign_criterion.location.geo_target_constant,
                  campaign_criterion.proximity.geo_point.longitude_in_micro_degrees,
                  campaign_criterion.proximity.geo_point.latitude_in_micro_degrees,
                  campaign_criterion.proximity.radius,
                  campaign_criterion.negative
            FROM campaign_criterion
            WHERE campaign_criterion.campaign = 'customers/{customerId}/campaigns/{campaignId}'
                AND campaign_criterion.type IN (LOCATION, PROXIMITY)
            ";

            try
            {
                // Issue a search request.
                googleAdsService.SearchStream(customerId.ToString(), query,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        Console.WriteLine("Geo Target Location(s):\n");
                        foreach (GoogleAdsRow dataRow in resp.Results)
                        {
                            // /*
                            Console.WriteLine(
                                $"Campaign Name: {dataRow.CampaignCriterion.Campaign}\n" +
                                $"Campaign location geo target constant: {dataRow.CampaignCriterion.Location?.GeoTargetConstant}\n" +
                                $"Campaign Criterion ID: {dataRow.CampaignCriterion.CriterionId}\n\n"
                                );
                            // */
                        }
                    }
                );
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        public static void getAudienceInfo(long customerId, long campaignId)
        {
            GoogleAdsClient googleAdsClient = new GoogleAdsClient();

            GoogleAdsClient client = new GoogleAdsClient();

            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V8.GoogleAdsService);

            // Create a query that will retrieve all campaigns.
            // pchu: for more information on query, please visit;
            // https://developers.google.com/google-ads/api/docs/targeting/location-targeting#c

            string query =
                $@"SELECT
                  campaign_criterion.campaign,
                  campaign_criterion.criterion_id,
                  campaign_criterion.age_range.type,
                  campaign_criterion.gender.type,
                  campaign_criterion.negative
            FROM campaign_criterion
            WHERE campaign_criterion.campaign = 'customers/{customerId}/campaigns/{campaignId}'
            ";

            try
            {
                // Issue a search request.
                googleAdsService.SearchStream(customerId.ToString(), query,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        Console.WriteLine("Demographics Info:\n");
                        foreach (GoogleAdsRow dataRow in resp.Results)
                        {
                            Console.WriteLine(
                                $"Campaign Name: {dataRow.CampaignCriterion.Campaign}\n" +
                                $"Campaign Criterion ID: {dataRow.CampaignCriterion.CriterionId}\n" +
                                $"Age Range Type: {dataRow.CampaignCriterion.AgeRange?.Type}\n" +
                                $"Gender Type: {dataRow.CampaignCriterion.Gender?.Type}\n" +
                                $"Negative Status: {dataRow.CampaignCriterion.Negative}\n\n"
                                );
                        }
                    }
                );
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        public static CampaignCriterion buildLocationCriterion(long customerId, long campaignId, long locationId)
        {
            // Set the Campaign Resource Name
            string campaignResourceName = ResourceNames.Campaign(customerId, campaignId);

            GeoTargetConstantName location = new GeoTargetConstantName(locationId.ToString());
            return new CampaignCriterion()
            {
                Campaign = campaignResourceName,
                Location = new LocationInfo()
                {
                    GeoTargetConstant = location.ToString()
                }
            };
        }

        //Please refer to "AddDemographicTargetingCriteria.cs"
        public static CampaignCriterion buildAgeRangeCampaignCriterion(long customerId, long campaignId, int isNegative, int ageRange)
        {
            string campaignResourceName = ResourceNames.Campaign(customerId, campaignId);
            bool boolValue = isNegative != 0;

            AgeRangeType tmp = new AgeRangeType();
            switch (ageRange)
            {
                case 0:
                    tmp = AgeRangeType.AgeRange1824;
                    break;
                case 1:
                    tmp = AgeRangeType.AgeRange2534;
                    break;
                case 2:
                    tmp = AgeRangeType.AgeRange3544;
                    break;
                case 3:
                    tmp = AgeRangeType.AgeRange4554;
                    break;
                case 4:
                    tmp = AgeRangeType.AgeRange5564;
                    break;
                case 5:
                    tmp = AgeRangeType.AgeRange65Up;
                    break;
                default:
                    tmp = AgeRangeType.AgeRange65Up;
                    break;
            }

            Console.WriteLine(boolValue);
            Console.WriteLine(tmp);
            Console.ReadLine();

            // Creates a negative campaign criterion for age range.
            return new CampaignCriterion()
            {
                Campaign = campaignResourceName,
                Negative = false,
                AgeRange = new AgeRangeInfo()
                {
                    //Type = AgeRangeType.AgeRange1824,
                    Type = tmp,
                }
            };
        }

        public static AdGroupCriterion buildAgeRangeAdGroupCriterion(long customerId, long adGroupId, int isNegative, int ageRange)
        {
            string adGroupResourceName = ResourceNames.AdGroup(customerId, adGroupId);
            Console.WriteLine($"ad group resource name: {adGroupResourceName}");

            bool boolValue = isNegative != 0;

            AgeRangeType tmp = new AgeRangeType();
            switch (ageRange)
            {
                case 0:
                    tmp = AgeRangeType.AgeRange1824;
                    break;
                case 1:
                    tmp = AgeRangeType.AgeRange2534;
                    break;
                case 2:
                    tmp = AgeRangeType.AgeRange3544;
                    break;
                case 3:
                    tmp = AgeRangeType.AgeRange4554;
                    break;
                case 4:
                    tmp = AgeRangeType.AgeRange5564;
                    break;
                case 5:
                    tmp = AgeRangeType.AgeRange65Up;
                    break;
                default:
                    tmp = AgeRangeType.AgeRange65Up;
                    break;
            }

            Console.WriteLine(boolValue);
            Console.WriteLine(tmp);
            Console.ReadLine();

            // Creates a negative adGroup criterion for age range.
            return new AdGroupCriterion()
            {
                AdGroup = adGroupResourceName,
                Negative = false,
                AgeRange = new AgeRangeInfo()
                {
                    //Type = AgeRangeType.AgeRange1824,
                    Type = tmp,
                }
            };
        }

        public static CampaignCriterion buildGenderCriterion(long customerId, long campaignId, GenderInfo genderValue)
        {
            string campaignResourceName = ResourceNames.Campaign(customerId, campaignId);

            Console.WriteLine(genderValue.Type.ToString());

            // Creates a NEGATIVE campaign criterion for GENDER.
            return new CampaignCriterion()
            {
                Campaign = campaignResourceName,
                // Makes this criterion negative.
                Negative = true,

                // COULDN'T GET THIS WORKING... NEED HELP
                Gender = //genderValue
                // /*
                new GenderInfo()
                {
                    Type = GenderType.Undetermined
                }
                // */
            };
        }

        public static AdGroupCriterion buildCustomInterestCriterion(long customerId, long adGroupId, string interest)
        {
            string adGroupResourceName = ResourceNames.AdGroup(customerId, adGroupId);

            Console.WriteLine(interest);

            // Creates a NEGATIVE campaign criterion for GENDER.
            return new AdGroupCriterion()
            {
                AdGroup = adGroupResourceName,
                // Makes this criterion negative.
                Negative = false,

                // COULDN'T GET THIS WORKING... NEED HELP
                CustomIntent = new CustomIntentInfo()
                {
                    CustomIntent = adGroupResourceName,

                }
            };
        }


        public static CampaignCriterion buildKeywordCampaignCriterion(long customerId, long campaignId, bool is_search, string searchTerm)
        {
            string campaignResourceName = ResourceNames.Campaign(customerId, campaignId);

            // Creates a ...
            return new CampaignCriterion()
            {
                Campaign = campaignResourceName,
                // Makes this criterion POSITIVE / NEGATIVE based on input
                Negative = is_search,
                // Keyword based on input text
                Keyword = new KeywordInfo()
                {
                    MatchType = Google.Ads.GoogleAds.V8.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType.Broad,
                    Text = searchTerm
                }
            };
        }

        public static AdGroupCriterion buildKeywordAdGroupCriterion(long customerId, long adGroupId, bool is_search, string searchTerm)
        {
            //string adGroupResourceName = ResourceNames.AdGroup(customerId, adGroupId);

            // Creates a ...
            return new AdGroupCriterion()
            {
                AdGroup = ResourceNames.AdGroup(customerId, adGroupId),
                Status = AdGroupCriterionStatus.Enabled,
                // Makes this criterion POSITIVE / NEGATIVE based on input
                Negative = is_search,
                // Keyword based on input text
                Keyword = new KeywordInfo()
                {

                    Text = searchTerm,
                    MatchType = KeywordMatchType.Exact
                    //MatchType = GoogleAds.V8.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType.Broad
                }
            };
        }

        /// <summary>
        /// Creates a proximity Criterion.
        /// </summary>
        public static CampaignCriterion buildProximityCriterion(long customerId, long campaignId)
        {
            // Set the Campaign Resource Name
            string campaignResourceName = ResourceNames.Campaign(customerId, campaignId);

            ProximityInfo proximity = new ProximityInfo()
            {
                Address = new AddressInfo()
                {
                    StreetAddress = "1140 alskdfjasldfSheppard Ave W Suite 20",
                    CityName = "North York",
                    //PostalCode = "M3K 2A2",
                    CountryCode = "CA"
                },
                Radius = 10d,
                // Default is kilometers.
                RadiusUnits = ProximityRadiusUnits.Kilometers
            };

            return new CampaignCriterion()
            {
                Campaign = campaignResourceName,
                Proximity = proximity
            };
        }
        public static void addGeoTargetLocationCriterion(long customerId, long campaignId, long locationId)
        {
            // Get the CampaignCriterionService.
            GoogleAdsClient client = new GoogleAdsClient();
            CampaignCriterionServiceClient campaignCriterionService =
                client.GetService(Services.V8.CampaignCriterionService);

            //1. locationId
            //CampaignCriterion geoCriterion = buildLocationCriterion(customerId, campaignId, locationId);

            //2. address
            CampaignCriterion geoCriterion = buildProximityCriterion(customerId, campaignId);
            //CampaignCriterion geoCriterion = new V8.AddCampaignTargetingCriteria().buildProximityCriterion(campaignResourceName);

            //Console.WriteLine(geoCriterion.Campaign.ToString());
            //Console.WriteLine(geoCriterion.Proximity.Radius.ToString());
            //Console.ReadLine();

            CampaignCriterionOperation geoCriterionOperation =
                new CampaignCriterionOperation()
                {
                    Create = geoCriterion
                };

            CampaignCriterionOperation[] operations = new CampaignCriterionOperation[] {
                //negativeCriterionOperation,
                //locationCriterionOperation,
                //proximityCriterionOperation
                geoCriterionOperation
            };

            try
            {
                // Create the campaign criterion.
                MutateCampaignCriteriaResponse response =
                    campaignCriterionService.MutateCampaignCriteria(customerId.ToString(),
                        operations);

                // Display the results.
                foreach (MutateCampaignCriterionResult criterionResult in response.Results)
                {
                    Console.WriteLine($"\nNew campaign criterion with resource name = " +
                        $"'{criterionResult.ResourceName}' and " +
                        $"Address = '{criterionResult.CampaignCriterion?.Proximity.Address}' and " +
                        $"Radius = '{criterionResult.CampaignCriterion?.Proximity.Radius.ToString()} " +
                        $"{criterionResult.CampaignCriterion?.Proximity.RadiusUnits.ToString()}' and " +
                        $"campaign ID {campaignId}.\n");
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        public static void addAgeRangeCampaignCriterion(long customerId, long campaignId, int isNegative, int ageRange)
        {
            // Get the CampaignCriterionService.
            GoogleAdsClient client = new GoogleAdsClient();
            CampaignCriterionServiceClient campaignCriterionService =
                client.GetService(Services.V8.CampaignCriterionService);

            CampaignCriterion ageRangeCriterion = buildAgeRangeCampaignCriterion(customerId, campaignId,
                isNegative, ageRange);

            CampaignCriterionOperation ageRangeCriterionOperation =
                new CampaignCriterionOperation()
                {
                    Create = ageRangeCriterion
                };


            CampaignCriterionOperation[] operations2 = new CampaignCriterionOperation[] {
                //negativeCriterionOperation,
                ageRangeCriterionOperation,
                //proximityCriterionOperation
            };

            try
            {
                // Create the campaign criterion.
                MutateCampaignCriteriaResponse response =
                    campaignCriterionService.MutateCampaignCriteria(customerId.ToString(),
                        operations2);

                Console.WriteLine("SUCCESS");

                // Display the results.
                foreach (MutateCampaignCriterionResult criterionResult in response.Results)
                {
                    Console.WriteLine($"\nNew campaign criterion with resource name = " +
                        $"'{criterionResult.ResourceName}' and AgeRange = " +
                        $"'' was added to campaign " +
                        $"ID {campaignId}.\n");

                    //{ criterionResult.CampaignCriterion?.AgeRange.ToString()}
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        public static void addAgeRangeAdGroupCriterion(long customerId, long adGroupId, int isNegative, int ageRange)
        {
            // Get the CampaignCriterionService.
            GoogleAdsClient client = new GoogleAdsClient();
            AdGroupCriterionServiceClient adGroupCriterionService =
                client.GetService(Services.V8.AdGroupCriterionService);

            AdGroupCriterion ageRangeCriterion = buildAgeRangeAdGroupCriterion(customerId, adGroupId,
                isNegative, ageRange);

            AdGroupCriterionOperation ageRangeCriterionOperation =
                new AdGroupCriterionOperation()
                {
                    Create = ageRangeCriterion
                };


            AdGroupCriterionOperation[] operations2 = new AdGroupCriterionOperation[] {
                //negativeCriterionOperation,
                ageRangeCriterionOperation,
                //proximityCriterionOperation
            };

            try
            {
                // Create the adGroup criterion.
                MutateAdGroupCriteriaResponse response =
                    adGroupCriterionService.MutateAdGroupCriteria(customerId.ToString(),
                        operations2);

                Console.WriteLine("SUCCESS");

                // Display the results.
                foreach (MutateAdGroupCriterionResult criterionResult in response.Results)
                {
                    Console.WriteLine($"\nNew adGroup criterion with resource name = " +
                        $"'{criterionResult.ResourceName}' and AgeRange = " +
                        $"'' was added to adGroup " +
                        $"ID {adGroupId}.\n");

                    //{ criterionResult.AdGroupCriterion?.AgeRange.ToString()}
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        public static void addGenderCriterion(long customerId, long campaignId)
        {
            // Get the CampaignCriterionService.
            GoogleAdsClient client = new GoogleAdsClient();
            CampaignCriterionServiceClient campaignCriterionService =
                client.GetService(Services.V8.CampaignCriterionService);

            // Negative on Undetermined AND Unknwon
            GenderInfo genderT1 = new GenderInfo { Type = GenderType.Undetermined };
            GenderInfo genderT2 = new GenderInfo { Type = GenderType.Unknown };

            CampaignCriterion genderT1Criterion = buildGenderCriterion(customerId, campaignId, genderT1);
            CampaignCriterion genderT2Criterion = buildGenderCriterion(customerId, campaignId, genderT2);

            Console.WriteLine(genderT1Criterion.Campaign.ToString());
            Console.WriteLine(genderT1Criterion.Type.ToString());
            Console.WriteLine(genderT2Criterion.Campaign.ToString());
            Console.WriteLine(genderT2Criterion.Type.ToString());

            CampaignCriterionOperation genderT1CriterionOperation =
                new CampaignCriterionOperation()
                {
                    Create = genderT1Criterion
                };

            CampaignCriterionOperation genderT2CriterionOperation =
                new CampaignCriterionOperation()
                {
                    Create = genderT2Criterion
                };

            CampaignCriterionOperation[] operations = new CampaignCriterionOperation[] {
                //genderT1CriterionOperation,
                genderT2CriterionOperation
            };

            try
            {
                // Create the campaign criterion.
                MutateCampaignCriteriaResponse response =
                    campaignCriterionService.MutateCampaignCriteria(customerId.ToString(),
                        operations);

                // Display the results.
                foreach (MutateCampaignCriterionResult criterionResult in response.Results)
                {
                    Console.WriteLine($"\nNew campaign criterion with resource name = " +
                        $"'{criterionResult.ResourceName}' was added to campaign " +
                        $"ID {campaignId}.\n");
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        /// <summary>
        /// The default keyword text.
        /// </summary>
        private const string KEYWORD_TEXT = "mars cruise";

        /// <summary>
        /// /
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="adGroupId"></param>
        /// <param name="is_search">whether to set the search text as POSITIVE or NEGATIVE keyword</param>
        /// <param name="search_text"></param>
        public static void addKeywordAdGroupCriterion(long customerId, long adGroupId, bool is_search, string search_text)
        {
            if (string.IsNullOrEmpty(search_text))
            {
                search_text = KEYWORD_TEXT;
            }
            // Get the CampaignCriterionService.
            GoogleAdsClient client = new GoogleAdsClient();

            // Get the AdGroupCriterionService.
            AdGroupCriterionServiceClient adGroupCriterionService =
                client.GetService(Services.V8.AdGroupCriterionService);

            //Create a keyword
            AdGroupCriterion keywordCriterion = buildKeywordAdGroupCriterion(customerId, adGroupId, is_search, search_text);

            AdGroupCriterionOperation keywordOperation =
                new AdGroupCriterionOperation()
                {
                    Create = keywordCriterion
                };

            AdGroupCriterionOperation[] operations = new AdGroupCriterionOperation[] {
                keywordOperation,
            };

            try
            {

                // Add the keywords.
                MutateAdGroupCriteriaResponse response =
                    adGroupCriterionService.MutateAdGroupCriteria(customerId.ToString(),
                        operations);

                // Display the results.
                if (response.Results.Count > 0)
                {
                    foreach (MutateAdGroupCriterionResult newCriterion in response.Results)
                    {
                        Console.WriteLine($"Created keyword with resource ID = " +
                            $"'{newCriterion.ResourceName}'.");
                    }
                }
                else
                {
                    Console.WriteLine("No keywords were added.");
                }
            }

            /*
            CampaignCriterionServiceClient campaignCriterionService =
                client.GetService(Services.V8.CampaignCriterionService);
            
            CampaignCriterion keywordCriterion = buildKeywordCampaignCriterion(customerId, campaignId, is_search, search_text);

            CampaignCriterionOperation keywordOperation =
                new CampaignCriterionOperation()
                {
                    Create = keywordCriterion
                };

            CampaignCriterionOperation[] operations = new CampaignCriterionOperation[] {
                keywordOperation,
            };

            try
            {
                // Create the campaign criterion.
                MutateCampaignCriteriaResponse response =
                    campaignCriterionService.MutateCampaignCriteria(customerId.ToString(),
                        operations);

                // Display the results.
                foreach (MutateCampaignCriterionResult criterionResult in response.Results)
                {
                    Console.WriteLine($"\nNew campaign criterion with resource name = " +
                        $"'{criterionResult.ResourceName}' was added to campaign " +
                        $"ID {campaignId}.\n");
                }
            }
            */

            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        public static void RemoveAdGroupCriterion(long customerId, long adGroupId, long criterionId)
        {
            // Get the CampaignCriterionService.
            GoogleAdsClient client = new GoogleAdsClient();

            // Get the AdGroupCriterionService.
            AdGroupCriterionServiceClient adGroupCriterionService = client.GetService(
                Services.V8.AdGroupCriterionService);

            // Create the operation.
            AdGroupCriterionOperation operation = new AdGroupCriterionOperation();
            operation.Remove = ResourceNames.AdGroupCriterion(customerId, adGroupId, criterionId);

            try
            {
                // Remove the keyword.
                MutateAdGroupCriteriaResponse retVal =
                    adGroupCriterionService.MutateAdGroupCriteria(customerId.ToString(),
                        new AdGroupCriterionOperation[] { operation });

                // Display the results.
                MutateAdGroupCriterionResult removedKeyword = retVal.Results[0];
                Console.WriteLine($"Keyword with resource name = " +
                    $"'{removedKeyword.ResourceName}' was removed.");
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }


        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="locationIds">The list of location IDs to restrict the search.</param>
        /// <param name="languageId">The language to restrict the search.</param>
        /// <param name="keywordTexts">The list of seed keywords.</param>
        /// <param name="pageUrl">The seed page URL.</param>
        /// <param name="num_result">Number of results to be displayed</param>
        // [START GenerateKeywordIdeas]
        public static void GenerateKeywordIdeas(GoogleAdsClient client, long customerId, long[] locationIds,
            long languageId, string[] keywordTexts, string pageUrl, int num_result)
        {
            KeywordPlanIdeaServiceClient keywordPlanIdeaService =
                client.GetService(Services.V8.KeywordPlanIdeaService);

            // Make sure that keywords and/or page URL were specified. The request must have
            // exactly one of urlSeed, keywordSeed, or keywordAndUrlSeed set.
            if (keywordTexts.Length == 0 && string.IsNullOrEmpty(pageUrl))
            {
                throw new ArgumentException("At least one of keywords or page URL is required, " +
                    "but neither was specified.");
            }

            // Specify the optional arguments of the request as a keywordSeed, UrlSeed,
            // or KeywordAndUrlSeed.
            GenerateKeywordIdeasRequest request = new GenerateKeywordIdeasRequest()
            {
                CustomerId = customerId.ToString(),
            };

            if (keywordTexts.Length == 0)
            {
                // Only page URL was specified, so use a UrlSeed.
                request.UrlSeed = new UrlSeed()
                {
                    Url = pageUrl
                };
            }
            else if (string.IsNullOrEmpty(pageUrl))
            {
                // Only keywords were specified, so use a KeywordSeed.
                request.KeywordSeed = new KeywordSeed();
                request.KeywordSeed.Keywords.AddRange(keywordTexts);
            }
            else
            {
                // Both page URL and keywords were specified, so use a KeywordAndUrlSeed.
                request.KeywordAndUrlSeed = new KeywordAndUrlSeed();
                request.KeywordAndUrlSeed.Url = pageUrl;
                request.KeywordAndUrlSeed.Keywords.AddRange(keywordTexts);
            }


            // Create a list of geo target constants based on the resource name of specified
            // location IDs.
            foreach (long locationId in locationIds)
            {
                request.GeoTargetConstants.Add(ResourceNames.GeoTargetConstant(locationId));
            }

            request.Language = ResourceNames.LanguageConstant(languageId);
            // Set the network. To restrict to only Google Search, change the parameter below to
            // KeywordPlanNetwork.GoogleSearch.
            request.KeywordPlanNetwork = KeywordPlanNetwork.GoogleSearchAndPartners;

            try
            {
                // Generate keyword ideas based on the specified parameters.
                var response =
                    keywordPlanIdeaService.GenerateKeywordIdeas(request);

                List<string> listIdeaText = new List<string>();
                List<long> listAvgMonthlySearches = new List<long>();
                List<string> listCompetition = new List<string>();


                // Iterate over the results and print its detail.
                foreach (GenerateKeywordIdeaResult result in response)
                {
                    KeywordPlanHistoricalMetrics metrics = result.KeywordIdeaMetrics;
                    if (!(metrics == null))
                    {

                        Console.WriteLine($"Keyword idea text '{result.Text}' has " +
                            $"{metrics.AvgMonthlySearches} average monthly searches and competition " +
                            $"is {metrics.Competition.ToString()}."
                        );

                        listIdeaText.Add(result.Text);
                        listAvgMonthlySearches.Add(metrics.AvgMonthlySearches);
                        listCompetition.Add(metrics.Competition.ToString());
                    }
                }
                /*
                //Generate dataframe
                var TextColumn = new StringDataFrameColumn("Text", listIdeaText);
                var AvgMonthlySearchColumn = new PrimitiveDataFrameColumn<long>("AvgMonthlySearch", listAvgMonthlySearches);
                var CompetitionColumn = new StringDataFrameColumn("Competition", listCompetition);

                //2. Create dataframe. This will fail if columns have different length
                var dataDf = new DataFrame(TextColumn, AvgMonthlySearchColumn, CompetitionColumn);

                //3. Sort by the AvgMonthlySearch Column
                DataFrame sorted = dataDf.OrderByDescending("AvgMonthlySearch");

                sorted.Head(num_result).PrettyPrint();
                */
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }
        // [END GenerateKeywordIdeas]
        public static void Main(string[] args)
        {
            // Turn on detailed logging. This is useful for debugging your requests.
            // You should also replace INSERT_PATH_TO_DETAILED_LOGS_HERE to a file path that will
            // be used to write the detailed logs to. E.g. C:\\logs\\details.log
            // Detailed logs.
            /*
            TraceUtilities.Configure(TraceUtilities.DETAILED_REQUEST_LOGS_SOURCE,
                "C:\\Users\\Powell\\Documents\\GitHub\\google-ads-dotnet\\examples\\details.log", System.Diagnostics.SourceLevels.All);
            // Summary logs.
            TraceUtilities.Configure(TraceUtilities.SUMMARY_REQUEST_LOGS_SOURCE,
                "C:\\Users\\Powell\\Documents\\GitHub\\google-ads-dotnet\\examples\\summary.log", System.Diagnostics.SourceLevels.All);
            */

            // If the API log doesn't give you enough details, then you can enable more low level
            // logging at grpc level. Keep in mind that this can get pretty detailed and long. The
            // grpc logs are written to stderr.
            // You can find all the supported environment variables here:
            // https://github.com/grpc/grpc/blob/master/doc/environment_variables.md

            //Environment.SetEnvironmentVariable("GRPC_VERBOSITY", "DEBUG");
            //Environment.SetEnvironmentVariable("GRPC_TRACE", "http");


            // Example IDs
            long campaignId = 12429579081;      //Sales-Search-1
            long adGroupId = 123916148808;      //Ad group 1
                                                //long adGroupAdId = 501249185460;    //Ad name: ""


            //// RUN pchu0 TO CREATE A NEW CAMPAIGN [PAUSED STATUS]

            //-pchu0: Test Create new campaign
            // you can refer to "AddCampaigns.cs" from Google.Ads.GoogleAds.Examples --> BasicOperations --> AddCampaigns.cs
            CreateCampaign(customerId);
            Console.WriteLine("-pchu0: New Campaign created. Please check...");
            Console.ReadLine();

            //-pchu1a1: Test Age Range view
            //Console.WriteLine("-pchu0: look at adGroup info (age range)");
            //getAgeRangeInfo(customerId, campaignId, adGroupId);
            //Console.ReadLine();

            //-pchu1ab: Get Criterion ID of Ad Group
            //-- ISSUE: JUN 21ST: CANNOT LOOK AT "NEGATIVE selection" age / gender INFO?
            //-- "EXCLUDED FROM CAMPAIGN, but the ad group criterion status (18to24) is still "Enabled"?
            Console.WriteLine("-pchu1ab: Look at adGroup criteria");
            GetAdGroupCriteria(customerId, adGroupId);
            Console.ReadLine();

            //-pchu1b: List Campaign Info
            Console.WriteLine("-pchu1b: Lists campaign info");
            ListCampaignInfoStats(customerId);

            //-pchu1b2: List all adgroups, ads, and campaigns Info of a customer -- ISSUE: JUN 21ST: CANNOT LOOK AT PAUSED INFO?
            Console.WriteLine("-pchu1b2: Lists ALL info of a campaign at the ADs level");
            ListAdGroupAdInfoStats(customerId);

            //-pchu1c: Pause a campaign
            //PauseCampaign(customerId, campaignId);
            //Console.ReadLine();

            //-pchu1c2: Enable a campaign
            //EnableCampaign(customerId, campaignId);
            //Console.ReadLine();

            //-pchu1d: Pause an adGroup
            //PauseAdGroup(customerId, adGroupId);
            //Console.ReadLine();

            //-pchu1d2: Enable an adGroup
            //EnableAdGroup(customerId, adGroupId);
            //Console.ReadLine();


            //// August 12th --> Add keywords to existing adgroup


            //-pchu9: Add Keyword Criterion (to Ad Group! Can also do it to Campaign)
            ///*
            //long adGroupId = 121290976922;
            string insert_word = "Pizza";
            bool is_Negative_keyword = false; //switch to 'true' if want negative keyword
            addKeywordAdGroupCriterion(customerId, adGroupId, is_Negative_keyword, insert_word);

            Console.WriteLine($"-pchu9: after insert keyword to adgroup: {adGroupId}");
            Console.ReadLine();
            //*/

            //-or run this: new V6.AddKeywords().Run(new GoogleAdsClient(), customerId, adGroupId, insert_word);

            //-pchu9b: trying to add keyword by FIRST add ad group in coding
            //long campaignId = 12429579081;
            //new V8.AddAdGroups().Run(new GoogleAdsClient(), customerId, campaignId);
            /*
            long adGroupId = 117064170462;
            string insert_word = "Baseball";
            new V8.AddKeywords().Run(new GoogleAdsClient(), customerId, adGroupId, insert_word);
            */






            //***********************************************************************************************//

            //// Code based on V6: Need Modifications:
            ///
            //-pchu2: Get campaign criteria
            //new V6.GetCampaignTargetingCriteria().Run(new GoogleAdsClient(), 2666127839, 12429579081);

            //-pchu3: Look up Location 'Constant' by name

            /* result:
             * ex.1: "Richmond Hill":
             * geoTargetConstants/1002405 (Richmond Hill, CA, City, Enabled) is found in locale (en) 
            with reach (542000) for search term (Richmond Hill).
             * ex.2: "M2N":
             * geoTargetConstants/9000914 (M2N, CA, Postal Code, Enabled) is found in locale (en) with reach (663000) for search term (M2N).
             */

            //new V6.GetGeoTargetConstantsByNames().Run(new GoogleAdsClient());
            //Console.WriteLine("After look up location...");
            //Console.ReadLine();

            //-pchu4: Add Campaign Criterion: Geo
            //long campaignId = 12429579081;
            //long locationId = 1002405;       //obtained from pchu3: Richmond Hill, CA
            //addGeoTargetLocationCriterion(customerId, campaignId, locationId);
            //new V6.AddCampaignTargetingCriteria().Run(new GoogleAdsClient(), customerId, campaignId, "temp", locationId);

            //Console.WriteLine("After add locationID to campaign...");
            //Console.ReadLine();


            //-pchu5: Target campaigns for proximity to a location
            //https://developers.google.com/google-ads/api/docs/targeting/location-targeting#c

            //-pchu6: retrieve campaign geo target location
            /*
            long campaignId = 12429579081;
            getGeoTarget(customerId, campaignId);
            */

            //-pchu7: Add Age Range Criterion
            /*

            string[] ageMinTicks = { "18", "25", "35", "45", "55", "65" };
            string[] ageMaxTicks = { "24", "34", "44", "54", "64", "UP" };
            // Example
            var ageMin = ageMinTicks[1];
            var ageMax = ageMaxTicks[3];
            //Do a check to ensure the two ticks are same length
            if (ageMinTicks.Length != ageMaxTicks.Length)
            {
                Console.WriteLine("Length of age ranges min and max are different. They have the be the same length");
            }
            //Find out the indices of positive and negative of age range
            var indMinAge = Array.FindIndex(ageMinTicks, x => x == ageMin);
            var indMaxAge = Array.FindIndex(ageMaxTicks, x => x == ageMax);
            if (indMinAge < 0 || indMaxAge < 0)
            {
                Console.WriteLine("Age selections are not in the range. Please verify.");
            }

            // Determine which age range is negative
            int[] isNegative = new int[ageMinTicks.Length];
            // indices below indMinAge needs to be switch to "1"
            if (indMinAge - 1 > -1)
            {
                for (int i = 0; i < indMinAge; i++)
                {
                    isNegative[i] = 1;
                }
            }
            // indices above indMaxAge needs to be switch to "1"
            if (ageMinTicks.Length - indMaxAge > 2)
            {
                for (int i = indMaxAge + 1; i < ageMinTicks.Length; i++)
                {
                    isNegative[i] = 1;
                }
            }

            foreach (int i in isNegative)
            {
                Console.WriteLine($"isNegative array: {i}");
            }
            Console.ReadLine();

            for (int i = 0; i < 1; i ++) // i < isNegative.Length; i++)
            {
                var ageRange = i;
                //long campaignId = 12429579081;
                //addAgeRangeCampaignCriterion(customerId, campaignId, isNegative[i], ageRange);
                addAgeRangeAdGroupCriterion(customerId, adGroupId, isNegative[i], ageRange);
            }
            */

            //-pchu8: Add Gender Criterion
            //long campaignId = 12429579081;
            //addGenderCriterion(customerId, campaignId);


            //-pchu10: retrieve campaign Audience Age / Gender Info
            //long campaignId = 12429579081;
            //getAudienceInfo(customerId, campaignId);

            //-pchu11: retreive campaign Keyword info
            //getCampaignKeywordsInfo(customerId);

            //-pchu12: retrieve adgroup keyword info
            //getAdGroupAdInfo(customerId);

            //-pchu13: checking out GenerateKeywordIdeas.cs

            //long[] list_locationId = { 1002405 };       //obtained from pchu3: Richmond Hill, CA
            //long[] list_locationId = { 9000914, 9000903, 9001016 }; //M2N, M1R, N1R
            //long languageId = 1000;
            //string[] list_insert_word = { "Basketball", "Books" };
            //new V6.GenerateKeywordIdeas().Run(new GoogleAdsClient(), customerId, list_locationId, languageId, list_insert_word, "");


            //-pchu13b: create own method --> sort --> pick top '10' keywords
            /*
            long[] list_locationId = { 1002405 }; // { 9000914 , 9000903, 9001016 }; //M2N, M1R, N1R
            long languageId = 1000;
            string[] list_insert_word = { "Bok" };
            string pageUrl = "";
            int num_result = 10;
            GenerateKeywordIdeas(new GoogleAdsClient(), customerId, list_locationId, languageId, list_insert_word, pageUrl, num_result);

            Console.WriteLine("after keywords lookup by locationIDs...");
            Console.ReadLine();
            */

            //-pchu14: testing custom interest info:
            /*
            long adGroupId = 121290976922;
            string interest = "Baseball";
            AdGroupCriterion test =  buildCustomInterestCriterion(customerId, adGroupId, interest);

            // Get the CampaignCriterionService.
            GoogleAdsClient client = new GoogleAdsClient();
            AdGroupCriterionServiceClient AdGroupCriterionService =
                client.GetService(Services.V6.AdGroupCriterionService);

            AdGroupCriterionOperation cusInterestCriterionOperation =
                 new AdGroupCriterionOperation()
                 {
                     Create = test
                 };

            AdGroupCriterionOperation[] operations = new AdGroupCriterionOperation[] {
                cusInterestCriterionOperation
            };

            try
            {
                // Create the campaign criterion.
                MutateAdGroupCriteriaResponse response =
                    AdGroupCriterionService.MutateAdGroupCriteria(customerId.ToString(),
                        operations);

                // Display the results.
                foreach (MutateAdGroupCriterionResult criterionResult in response.Results)
                {
                    Console.WriteLine($"\nNew AdGroup criterion with resource name = " +
                        $"'{criterionResult.ResourceName}' was added to AdGroup " +
                        $"ID {adGroupId}.\n");
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
            */





        }
    }
}
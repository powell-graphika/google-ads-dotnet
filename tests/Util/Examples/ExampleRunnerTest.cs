﻿// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Ads.GoogleAds.Examples;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Tests.Util.Examples.V0;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Google.Ads.GoogleAds.Tests.Util.Examples
{
    /// <summary>
    /// UnitTests for <see cref="ExampleRunner"/> class.
    /// </summary>
    [TestFixture]
    [Category("Smoke")]
    [Parallelizable(ParallelScope.Self)]
    internal class ExampleRunnerTest
    {
        /// <summary>
        /// Test for <see cref="ExampleRunner.PrintAvailableExamples"/>
        /// </summary>
        [Test]
        public void TestPrintAvailableExamples()
        {
            ExampleRunner runner = new ExampleRunner();
            runner.LoadCodeExamples(this.GetType().Assembly,
                new System.Type[] { typeof(NoRunTestExample) });

            CaptureConsoleIOAndExecute(
                delegate ()
                {
                    runner.PrintAvailableExamples();
                },
                delegate (string output)
                {
                    Assert.AreEqual(
                        TestResources.UsageSummary.Replace("\r\n", "\n").Trim(), 
                        output.Replace("\r\n", "\n").Trim()
                    );
                }
            );
        }

        /// <summary>
        /// Test for <see cref="ExampleRunner.Run(string, GoogleAdsClient, IEnumerable{string})"/>
        /// </summary>
        [Test]
        public void TestRun()
        {
            ExampleRunner runner = new ExampleRunner();
            runner.LoadCodeExamples(this.GetType().Assembly);

            GoogleAdsClient client = new GoogleAdsClient();

            // Verify that you can run an example with the right set of arguments.
            CaptureConsoleIOAndExecute(
                delegate ()
                {
                    runner.Run(TestExample.TEST_EXAMPLE_NAME, 
                        new string[] {
                            $"--{TestExample.STRING_ARGS_NAME}={TestExample.STRING_ARG1}",
                            $"{TestExample.STRING_ARG2}",
                            $"--{TestExample.LONG_ARGS_NAME}={TestExample.LONG_ARG1}",
                            $"{TestExample.LONG_ARG2}",
                            $"{TestExample.LONG_ARG3}",
                            $"--{TestExample.SINGLE_STRING_ARG_NAME}={TestExample.SINGLE_STRING_ARG}",
                            $"--{TestExample.SINGLE_LONG_ARG_NAME}={TestExample.SINGLE_LONG_ARG}",
                        }
                    );
                }, null
            );

            // Verify that a KeyNotFoundException is thrown if the specified example
            // is not found.
            CaptureConsoleIOAndExecute(
                delegate ()
                {
                    Assert.Throws(typeof(KeyNotFoundException),
                        delegate ()
                        {
                            runner.Run("V1.NoSuchExample", new string[] { });
                        }
                    );
                }, null
            );

            // Verify that a MissingMethodException is thrown if the specified example
            // does not have a Run() method.
            CaptureConsoleIOAndExecute(
                delegate ()
                {
                    Assert.Throws(typeof(MissingMethodException),
                        delegate ()
                        {
                            runner.Run(NoRunTestExample.TEST_EXAMPLE_NAME, new string[] { });
                        }
                    );
                }, null
            );

            // If an unknown flag is passed, then the example may choose to handle it in the Main()
            // method by expecting a substution of INSERT_XXX_ parameters. If that succeeds, no
            // error may be raised. If it isn't, the exception will be thrown, with the site of
            // failure as the Main() method.
            CaptureConsoleIOAndExecute(
                delegate ()
                {
                    Assert.Throws(typeof(ArgumentException),
                        delegate ()
                        {
                            runner.Run(TestExample.TEST_EXAMPLE_NAME, new string[] { "--foo=bar" });
                        }
                    );
                }, null
            );
        }

        /// <summary>
        /// Captures the console input + output and execute a method.
        /// </summary>
        /// <param name="functionToRun">The function to run. This function should not read any
        /// input from the console.</param>
        /// <param name="afterRunCallback">The callback to be invoked after
        /// <paramref name="functionToRun"/> completes. The console output is passed as an
        /// argument to the action.</param>
        private void CaptureConsoleIOAndExecute(TestDelegate functionToRun,
            Action<string> afterRunCallback)
        {
            StringWriter writer = new StringWriter();
            StringReader reader = new StringReader("\r\n");

            TextWriter oldWriter = Console.Out;
            TextReader oldReader = Console.In;

            try
            {
                // Capture the console input and output.
                Console.SetOut(writer);
                Console.SetIn(reader);

                functionToRun?.Invoke();
                afterRunCallback?.Invoke(writer.ToString());
            }
            finally
            {
                // Restore the console input and output.
                Console.SetIn(oldReader);
                Console.SetOut(oldWriter);
            }
        }
    }
}

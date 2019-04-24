using System;

namespace HealthCare.Model
{
    /// <summary>
    /// Test model is used to keep track of patients tests and results of those tests
    /// </summary>
    public class Test
    {
        /// <summary>
        /// The test's code with getters and setters
        /// </summary>
        public string TestCode { get; set; }

        /// <summary>
        /// The name of the test with getters and setters
        /// </summary>
        public string TestName { get; set; }

        /// <summary>
        /// The visitID associated with the test record with getter and setter
        /// </summary>
        public int VisitId { get; set; }

        /// <summary>
        /// The result of the test with getter and setter
        /// </summary>
        public string Results { get; set; }

        /// <summary>
        /// Wether the result of the test was normal or abnormal with getter and setter
        /// </summary>
        public bool? Normal { get; set; }

        /// <summary>
        /// The date the test was ordered with getter and setter
        /// </summary>
        public DateTime TestDate { get; set; }

        /// <summary>
        /// The date the test was performed
        /// </summary>
        public DateTime? PerformDate { get; set; }
    }
}

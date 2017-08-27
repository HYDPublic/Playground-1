// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Playground.Client.Generated.Models
{
    using Newtonsoft.Json;
    using Playground.Client;
    using Playground.Client.Generated;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Company
    {
        /// <summary>
        /// Initializes a new instance of the Company class.
        /// </summary>
        public Company()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Company class.
        /// </summary>
        public Company(int? id = default(int?), string name = default(string), IList<Site> sites = default(IList<Site>))
        {
            Id = id;
            Name = name;
            Sites = sites;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sites")]
        public IList<Site> Sites { get; set; }

    }
}

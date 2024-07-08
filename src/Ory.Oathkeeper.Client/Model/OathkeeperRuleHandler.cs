/*
 * ORY Oathkeeper
 *
 * ORY Oathkeeper is a reverse proxy that checks the HTTP Authorization for validity against a set of rules. This service uses Hydra to validate access tokens and policies.
 *
 * The version of the OpenAPI document: v0.40.8
 * Contact: hi@ory.am
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Oathkeeper.Client.Client.OpenAPIDateConverter;

namespace Ory.Oathkeeper.Client.Model
{
    /// <summary>
    /// OathkeeperRuleHandler
    /// </summary>
    [DataContract(Name = "ruleHandler")]
    public partial class OathkeeperRuleHandler : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OathkeeperRuleHandler" /> class.
        /// </summary>
        /// <param name="config">Config contains the configuration for the handler. Please read the user guide for a complete list of each handler&#39;s available settings..</param>
        /// <param name="handler">Handler identifies the implementation which will be used to handle this specific request. Please read the user guide for a complete list of available handlers..</param>
        public OathkeeperRuleHandler(Object config = default(Object), string handler = default(string))
        {
            this.Config = config;
            this.Handler = handler;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Config contains the configuration for the handler. Please read the user guide for a complete list of each handler&#39;s available settings.
        /// </summary>
        /// <value>Config contains the configuration for the handler. Please read the user guide for a complete list of each handler&#39;s available settings.</value>
        [DataMember(Name = "config", EmitDefaultValue = false)]
        public Object Config { get; set; }

        /// <summary>
        /// Handler identifies the implementation which will be used to handle this specific request. Please read the user guide for a complete list of available handlers.
        /// </summary>
        /// <value>Handler identifies the implementation which will be used to handle this specific request. Please read the user guide for a complete list of available handlers.</value>
        [DataMember(Name = "handler", EmitDefaultValue = false)]
        public string Handler { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OathkeeperRuleHandler {\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Handler: ").Append(Handler).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

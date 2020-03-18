// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ImplantTemplate
    {
        /// <summary>
        /// Initializes a new instance of the ImplantTemplate class.
        /// </summary>
        public ImplantTemplate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImplantTemplate class.
        /// </summary>
        /// <param name="language">Possible values include: 'CSharp'</param>
        /// <param name="commType">Possible values include: 'HTTP', 'SMB',
        /// 'Bridge'</param>
        /// <param name="implantDirection">Possible values include: 'Push',
        /// 'Pull'</param>
        public ImplantTemplate(int? id = default(int?), string name = default(string), string description = default(string), ImplantLanguage? language = default(ImplantLanguage?), CommunicationType? commType = default(CommunicationType?), ImplantDirection? implantDirection = default(ImplantDirection?), IList<ListenerType> compatibleListenerTypes = default(IList<ListenerType>), string stagerCode = default(string), string executorCode = default(string))
        {
            Id = id;
            Name = name;
            Description = description;
            Language = language;
            CommType = commType;
            ImplantDirection = implantDirection;
            CompatibleListenerTypes = compatibleListenerTypes;
            StagerCode = stagerCode;
            ExecutorCode = executorCode;
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
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'CSharp'
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public ImplantLanguage? Language { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'HTTP', 'SMB', 'Bridge'
        /// </summary>
        [JsonProperty(PropertyName = "commType")]
        public CommunicationType? CommType { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Push', 'Pull'
        /// </summary>
        [JsonProperty(PropertyName = "implantDirection")]
        public ImplantDirection? ImplantDirection { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "compatibleListenerTypes")]
        public IList<ListenerType> CompatibleListenerTypes { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stagerCode")]
        public string StagerCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "executorCode")]
        public string ExecutorCode { get; set; }

    }
}

/* 
 * The Selling Partner API for FBA inbound operations.
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * OpenAPI spec version: 2024-03-20
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInboundv20240320
{
    /// <summary>
    /// Specifies the dates that the seller expects their shipment will be shipped and delivered.
    /// </summary>
    [DataContract]
    public partial class Dates :  IEquatable<Dates>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dates" /> class.
        /// </summary>
        /// <param name="deliveryWindow">deliveryWindow.</param>
        /// <param name="readyToShipWindow">readyToShipWindow.</param>
        public Dates(Window deliveryWindow = default(Window), Window readyToShipWindow = default(Window))
        {
            this.DeliveryWindow = deliveryWindow;
            this.ReadyToShipWindow = readyToShipWindow;
        }
        
        /// <summary>
        /// Gets or Sets DeliveryWindow
        /// </summary>
        [DataMember(Name="deliveryWindow", EmitDefaultValue=false)]
        public Window DeliveryWindow { get; set; }

        /// <summary>
        /// Gets or Sets ReadyToShipWindow
        /// </summary>
        [DataMember(Name="readyToShipWindow", EmitDefaultValue=false)]
        public Window ReadyToShipWindow { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Dates {\n");
            sb.Append("  DeliveryWindow: ").Append(DeliveryWindow).Append("\n");
            sb.Append("  ReadyToShipWindow: ").Append(ReadyToShipWindow).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Dates);
        }

        /// <summary>
        /// Returns true if Dates instances are equal
        /// </summary>
        /// <param name="input">Instance of Dates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Dates input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeliveryWindow == input.DeliveryWindow ||
                    (this.DeliveryWindow != null &&
                    this.DeliveryWindow.Equals(input.DeliveryWindow))
                ) && 
                (
                    this.ReadyToShipWindow == input.ReadyToShipWindow ||
                    (this.ReadyToShipWindow != null &&
                    this.ReadyToShipWindow.Equals(input.ReadyToShipWindow))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DeliveryWindow != null)
                    hashCode = hashCode * 59 + this.DeliveryWindow.GetHashCode();
                if (this.ReadyToShipWindow != null)
                    hashCode = hashCode * 59 + this.ReadyToShipWindow.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
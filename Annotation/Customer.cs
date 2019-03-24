//-----------------------------------------------------------------------
// <copyright file="Customer.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.Annotation
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Class customer
    /// </summary>
    public class Customer
    {
        [Required(ErrorMessage = "Please enter the customer id")]
        //// Required Field
        [Range(0, 1000, ErrorMessage = "Id should be between 0 and 1000")]

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>
        /// The id
        /// </value>
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Customer Name")]
        //// Required Field
        [StringLength(20)]
        [RegularExpression(@"^[A-Z]{0,20}$")]

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Customer Address")]
        //// Required  field
        [StringLength(1)]

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address { get; set; }
    }
}

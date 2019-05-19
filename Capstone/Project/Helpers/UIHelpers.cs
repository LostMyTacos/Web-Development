using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Data;
using System.Collections.Generic;
using System.Linq;

namespace Project.Helpers
{
    public static class UIHelpers
    {
        /// <summary>
        /// Lets you create an IEnumerable List of SelectListItem required to generate a dropdown in the view with the 
        /// Html.dropdownlist helper.
        /// TODO: I will confirm if it works with the tag helper when I upgrade method to tag helper
        /// TODO: Find way to refine Method
        /// </summary>
        /// <param name="context">The reference to the HITProjectDataEntites</param>
        /// <param name="TableName">String value of tablename</param>
        /// <param name="ColumnForLabel">String value of the Column used to the dropdown item label</param>
        /// <param name="ColumnForValue">String value of the Column used for the dropdown item value</param>
        /// <returns>IEnumerable<SelectListItem> DropDownList</returns>
        public static IEnumerable<SelectListItem> BuildDownDownFromTable(
            HITProjectDataEntities context,
            string TableName,
            string ColumnForLabel,
            string ColumnForValue,
            string Selected = "")
        {
            IEnumerable<SelectListItem>DropDownList = new List<SelectListItem>();
            if (TableName == "EducationEarned" && ColumnForLabel == "Name" && ColumnForValue == "EductionEarnedId")
            {
                DropDownList = context.EducationEarned.Select(x =>
                new SelectListItem()
                {
                    Text = x.Name,
                    Value = x.EducationEarnedId.ToString(),
                    Selected = x.EducationEarnedId.ToString() == Selected ? true : false
                });
            }
            if (TableName == "EducationEarned" && ColumnForLabel == "Name" && ColumnForValue == "Name")
            {
                DropDownList = context.EducationEarned.Select(x =>
                new SelectListItem()
                {
                    Text = x.Name,
                    Value = x.Name,
                    Selected = x.EducationEarnedId.ToString() == Selected ? true : false
                });
            }

            if (TableName == "FacilityType" && ColumnForLabel == "TypeDescription" && ColumnForValue == "FacilityTypeId")
            {
                DropDownList = context.FacilityType.Select(x =>
                new SelectListItem()
                {
                    Text = x.TypeDescription,
                    Value = x.FacilityTypeId.ToString(),
                    Selected = x.FacilityTypeId.ToString() == Selected ? true : false
                });
            }
            if (TableName == "FacilityType" && ColumnForLabel == "TypeDescription" && ColumnForValue == "TypeDescription")
            {
                DropDownList = context.FacilityType.Select(x =>
                new SelectListItem()
                {
                    Text = x.TypeDescription,
                    Value = x.TypeDescription,
                    Selected = x.FacilityTypeId.ToString() == Selected ? true : false
                });
            }
            // TODO: Add support for other tables as needed.
            return DropDownList;
        }
    }   
}

using System;
using System.Drawing;
using Grasshopper.Kernel;


namespace epoch_time_component
{
    public class template_info : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return epoch_time_component.Properties.Resources.os_reading_epoch_time;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("015A04C7-0DAD-496A-B274-1106CBE41047"); // Tools -> Create Guid 5.
            }
        }
        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "Philipp Siedler";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "p.d.siedler@gmail.com";
            }
        }
    }
}

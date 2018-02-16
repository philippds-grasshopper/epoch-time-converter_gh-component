using System;
using System.Collections.Generic;
using Grasshopper.Kernel;
using System.Globalization;
using Rhino.Geometry;
using System.Linq;
using Grasshopper;

namespace gh_epoch_time_component
{
    public class gh_epoch_time_component : GH_Component
    {
        GH_Document GrasshopperDocument;
        IGH_Component Component;
        
        /// <summary>
        /// Each implementation of GH_Component must provide a public 
        /// constructor without any arguments.
        /// Category represents the Tab in which the component will appear, 
        /// Subcategory the panel. If you use non-existing tab or panel names, 
        /// new tabs/panels will automatically be created.
        /// </summary>
        public gh_epoch_time_component(): base("parse json", "fill", "action description", "philsComps", "Subcategory")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddTextParameter("epochTime", "epochTime", "epochTime", GH_ParamAccess.item);
            pManager.AddTimeParameter("humanTime", "humanTime", "humanTime", GH_ParamAccess.item);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddTimeParameter("toHumanTime", "toHumanTime", "toHumanTime", GH_ParamAccess.item);
            pManager.AddTextParameter("toEpochTime", "toEpochTime", "toEpochTime", GH_ParamAccess.item);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object can be used to retrieve data from input parameters and 
        /// to store data in output parameters.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            string epochTime = "";
            DateTime humanTime = new DateTime();

            DA.GetData(0, ref epochTime);
            DA.GetData(1, ref humanTime);

            gh_epoch_time EHT = new gh_epoch_time(epochTime, humanTime);
                        
            DA.SetData(0, EHT.hT);
            DA.SetData(1, EHT.eT);
        }

        /// <summary>
        /// Provides an Icon for every component that will be visible in the User Interface.
        /// Icons need to be 24x24 pixels.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                // You can add image files to your project resources and access them like this:
                //return Resources.IconForThisComponent;
                //return osAPIcomp.Properties.Resources.dup;                
                return null;                
            }
        }

        /// <summary>
        /// Each component must have a unique Guid to identify it. 
        /// It is vital this Guid doesn't change otherwise old ghx files 
        /// that use the old ID will partially fail during loading.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("015A04C7-0DAD-496A-B274-1106CBE41047"); }
        }
        
    }
}

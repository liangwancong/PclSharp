﻿// Code generated by a template
using PclSharp.Common;
using PclSharp.Search;
using PclSharp.Std;
using PclSharp.Struct;

namespace PclSharp.Segmentation
{
	public abstract class CPCSegmentation<PointT> : LCCPSegmentation<PointT>
	{
		public abstract void SetCutting(
			uint maxCuts = 20, 
			uint cuttingMinSegments=0, 
			float cuttingMinScore=0.16f, 
			bool locallyConstrained=true, 
			bool directedCutting=true, 
			bool cleanCutting=false);

		public abstract uint RANSACIterations { set; }
	}
}

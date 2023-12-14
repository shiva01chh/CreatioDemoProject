﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TimelineDataLoaderFactorySchema

	/// <exclude/>
	public class TimelineDataLoaderFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TimelineDataLoaderFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TimelineDataLoaderFactorySchema(TimelineDataLoaderFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f63c9670-f72b-4cd2-8019-beccad35886c");
			Name = "TimelineDataLoaderFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ef55f699-c757-427c-a5d6-6f8a0d355b0a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,85,75,111,211,64,16,62,167,82,255,195,96,46,137,20,57,247,188,80,73,91,20,65,74,81,195,9,161,178,216,147,100,165,245,218,154,93,183,50,21,255,157,177,215,142,31,173,9,112,193,183,221,157,199,55,223,55,51,214,34,66,147,136,0,97,139,68,194,196,59,235,175,98,189,147,251,148,132,149,177,246,183,50,66,37,53,158,159,61,157,159,13,82,35,245,30,238,50,99,49,98,67,165,48,200,173,140,255,14,53,146,12,102,71,155,102,60,194,190,123,255,90,4,54,38,137,134,45,216,230,53,225,158,227,193,74,9,99,96,10,85,246,75,97,197,135,88,132,72,206,33,43,172,39,147,9,204,77,26,69,130,178,101,121,222,8,45,246,8,82,27,43,116,128,6,226,29,132,236,13,170,112,255,102,252,202,113,210,240,76,210,239,74,6,16,20,105,123,147,206,183,75,120,60,32,49,91,83,103,59,134,245,115,107,142,247,84,224,59,150,115,45,81,133,102,10,183,36,31,132,69,247,152,184,3,16,138,48,214,42,131,75,89,144,201,144,230,198,18,147,53,6,78,120,239,128,111,68,50,107,122,5,204,186,5,103,7,247,33,238,68,170,172,203,15,11,240,174,180,149,54,187,11,14,24,137,79,41,82,230,205,74,72,168,67,135,170,13,241,150,226,4,201,178,18,57,204,216,178,176,24,66,133,180,58,127,54,72,220,31,218,201,222,57,158,200,176,202,17,83,154,51,153,231,40,24,119,22,93,29,139,139,181,150,86,10,37,127,176,134,2,52,62,30,53,205,37,181,7,100,23,100,30,8,119,11,175,87,50,111,178,116,74,249,199,68,77,221,43,225,123,253,135,35,200,251,126,48,168,101,96,122,115,52,47,170,53,28,21,34,253,252,31,117,37,130,68,4,154,39,122,225,165,45,97,188,229,186,63,69,91,67,142,235,207,39,69,168,229,63,50,214,233,145,54,148,209,148,243,75,115,164,181,99,188,232,152,55,217,236,235,171,13,218,67,220,59,93,91,88,241,128,89,116,24,43,30,134,229,224,56,81,111,152,179,10,16,161,77,169,219,217,240,138,53,79,149,130,55,110,51,149,165,242,214,179,188,19,134,117,148,113,17,99,144,171,218,104,247,11,218,167,17,106,59,236,234,50,238,228,25,141,96,234,34,252,62,77,171,203,234,74,185,57,93,153,253,229,61,8,26,168,106,75,188,200,76,55,75,163,243,253,139,48,108,22,91,198,47,237,74,230,220,221,95,10,87,238,151,238,186,217,2,151,126,82,185,65,75,185,6,92,38,214,10,158,174,247,152,53,203,98,21,107,163,47,245,195,87,254,225,212,20,246,176,125,186,152,83,139,141,75,106,141,188,202,243,244,172,167,103,131,93,163,242,150,229,182,207,31,90,51,91,77,104,77,222,219,44,247,56,73,157,123,247,215,230,134,123,253,35,93,69,137,237,18,247,92,143,246,191,135,27,248,5,155,63,224,178,188,107,94,241,13,255,128,248,251,5,238,24,3,247,166,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f63c9670-f72b-4cd2-8019-beccad35886c"));
		}

		#endregion

	}

	#endregion

}


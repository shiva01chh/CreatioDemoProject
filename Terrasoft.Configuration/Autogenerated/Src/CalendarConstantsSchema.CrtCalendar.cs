namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarConstantsSchema

	/// <exclude/>
	public class CalendarConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarConstantsSchema(CalendarConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("be7f28d4-9023-4e82-8abd-f8718e729d3d");
			Name = "CalendarConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d2179f89-6a33-4745-96ee-fd30f06a5c1f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,84,93,107,219,48,20,125,110,32,255,65,100,47,219,131,18,89,146,109,169,221,6,250,176,182,61,20,10,235,24,236,77,75,148,96,150,200,197,146,25,97,244,191,87,78,98,218,166,161,203,152,177,49,186,58,247,30,249,220,115,237,237,198,133,59,59,119,224,214,181,173,13,205,50,78,85,227,151,245,170,107,109,172,27,63,85,118,237,252,194,182,97,60,250,51,30,93,116,161,246,43,240,117,27,162,219,92,141,71,41,242,166,117,171,4,4,106,109,67,184,4,183,245,198,125,243,117,76,85,66,180,62,166,188,139,116,223,117,63,215,245,28,164,80,76,175,121,143,61,9,237,57,30,75,14,27,151,224,102,151,223,111,246,207,243,106,173,179,139,198,175,183,224,83,87,47,192,112,96,109,183,225,203,2,124,0,222,253,222,237,188,157,144,66,27,130,112,5,115,33,11,72,137,64,80,84,170,132,52,87,184,228,185,102,132,235,201,187,171,115,25,174,107,223,69,119,76,66,153,164,198,112,6,43,34,13,164,38,231,80,20,202,64,204,104,69,17,163,70,98,243,15,36,159,155,174,61,166,144,37,75,36,186,255,142,138,67,138,43,12,133,33,20,42,77,132,230,85,161,120,113,14,197,247,166,253,149,186,121,66,40,169,149,148,44,227,144,75,156,132,42,112,9,57,45,12,212,8,21,52,23,88,83,148,157,79,112,90,39,34,36,37,88,20,80,9,70,83,51,178,28,74,65,8,76,31,66,84,153,51,193,12,58,159,227,148,76,169,56,98,149,46,161,206,50,6,41,194,2,114,174,16,196,38,103,4,243,172,210,184,58,48,236,92,151,244,222,27,47,173,238,247,182,125,22,123,105,246,161,73,59,163,30,156,62,155,205,192,251,208,109,54,182,221,126,60,172,7,28,152,15,142,158,14,200,217,19,232,169,33,121,65,241,95,19,18,98,219,207,175,118,75,219,173,99,63,128,63,26,239,84,179,112,73,185,201,81,120,242,154,248,135,74,210,6,247,120,196,125,153,167,177,87,107,212,62,130,193,28,190,239,96,202,46,208,223,50,246,173,246,201,182,9,142,233,254,47,116,78,247,238,123,100,127,61,0,195,144,65,123,246,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("be7f28d4-9023-4e82-8abd-f8718e729d3d"));
		}

		#endregion

	}

	#endregion

}


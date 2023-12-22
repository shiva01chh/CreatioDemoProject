namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IncomingMessageNotifierSchema

	/// <exclude/>
	public class IncomingMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IncomingMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IncomingMessageNotifierSchema(IncomingMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bc6fbb0e-f49b-4d6a-b97a-206ce6b2a400");
			Name = "IncomingMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("92ff52b6-dfba-4556-90d8-6f4c37f69c5d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,84,77,75,3,49,16,61,111,193,255,48,212,203,246,96,246,238,71,193,15,42,133,86,197,143,147,120,136,217,217,54,176,155,44,73,182,82,196,255,238,108,178,41,181,186,130,32,226,158,54,201,204,155,247,222,76,162,120,133,182,230,2,225,30,141,225,86,23,142,157,107,85,200,69,99,184,147,90,177,235,74,73,177,228,74,97,201,230,104,45,95,72,181,216,27,188,238,13,146,198,210,47,220,173,173,195,138,178,202,18,69,155,98,217,37,42,52,82,28,109,98,182,193,13,178,9,23,78,27,137,150,34,40,102,223,224,130,242,224,188,228,214,30,194,84,9,93,81,86,168,134,87,218,201,66,162,241,161,89,150,193,177,109,170,138,155,245,184,91,223,98,109,208,162,114,22,68,139,112,160,186,12,40,180,129,176,32,14,165,36,158,196,203,2,127,214,141,3,133,47,80,133,18,44,34,103,91,208,143,23,88,240,166,116,103,82,229,148,159,186,117,141,186,72,167,61,244,70,163,39,74,170,155,231,82,138,192,163,79,8,144,196,94,141,73,107,236,198,145,137,196,50,39,75,110,140,92,113,135,222,130,164,14,11,176,142,58,36,96,70,186,142,119,1,103,157,216,113,148,24,55,58,203,147,125,84,121,40,210,173,99,15,168,127,206,52,109,127,168,238,157,47,209,158,119,197,122,120,167,35,240,188,147,221,106,112,226,125,254,158,99,58,106,39,37,121,251,158,217,28,221,82,123,51,188,199,225,208,119,77,170,37,141,155,203,53,25,111,176,56,25,254,104,150,89,95,51,134,144,141,189,223,161,167,43,45,115,56,205,243,72,251,211,36,196,131,93,203,251,188,97,4,150,238,198,110,59,241,215,226,110,177,210,43,252,61,125,1,239,95,73,244,103,235,13,197,116,131,210,229,70,109,81,19,189,32,200,197,18,250,205,136,207,10,72,245,233,174,69,148,36,6,177,135,58,167,171,27,45,9,86,180,94,124,57,253,221,222,199,11,65,123,219,223,59,3,241,161,166,193,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bc6fbb0e-f49b-4d6a-b97a-206ce6b2a400"));
		}

		#endregion

	}

	#endregion

}


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SimpleNotificationMessageBuilderSchema

	/// <exclude/>
	public class SimpleNotificationMessageBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SimpleNotificationMessageBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SimpleNotificationMessageBuilderSchema(SimpleNotificationMessageBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("314059c6-f688-44bf-b84c-c7c747f99b73");
			Name = "SimpleNotificationMessageBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,77,107,219,64,16,61,59,144,255,48,184,23,27,130,221,94,173,58,208,4,146,234,224,54,224,230,102,40,27,237,88,94,144,118,197,238,170,197,24,255,247,206,126,72,178,82,106,43,164,190,120,119,102,222,124,188,121,43,201,74,52,21,203,16,126,160,214,204,168,173,157,221,43,185,21,121,173,153,21,74,94,95,29,174,175,70,181,17,50,135,245,222,88,44,147,246,222,65,86,104,12,203,201,70,224,178,84,146,98,40,234,131,198,156,82,192,125,193,140,89,192,90,148,85,129,223,148,21,91,145,249,228,1,134,119,181,40,56,106,143,169,234,151,66,100,144,57,200,69,4,44,32,61,151,111,116,240,57,219,70,30,4,22,156,58,121,210,226,23,179,24,156,85,184,128,70,198,149,44,246,177,106,204,5,63,203,120,88,130,196,223,125,231,100,154,196,2,40,121,168,209,47,248,164,85,133,218,10,116,69,253,100,193,63,159,207,225,179,169,203,146,233,253,109,99,120,68,107,64,105,48,238,95,112,148,52,24,205,168,182,96,119,8,238,106,247,179,22,61,63,133,71,214,30,107,193,33,229,224,86,54,26,229,104,19,127,48,241,112,124,99,113,209,85,103,188,20,18,106,41,236,128,14,72,39,95,92,252,51,133,255,135,110,36,105,180,233,195,209,233,87,13,86,129,116,171,191,64,137,177,218,73,245,123,139,123,111,55,134,86,221,241,18,197,49,168,135,117,64,158,111,224,95,74,90,161,221,41,62,68,70,94,253,6,88,211,219,201,54,7,236,206,163,83,62,153,198,62,53,218,90,203,87,43,189,200,216,95,61,236,232,113,93,170,159,174,76,254,213,199,5,124,56,183,157,156,184,67,54,122,145,205,227,156,5,71,96,52,214,138,116,47,35,239,201,233,56,187,46,252,77,99,188,40,62,76,111,30,121,71,209,175,137,12,254,217,131,210,37,179,147,241,225,0,155,177,198,76,105,34,125,51,94,208,237,240,241,184,25,223,208,161,213,58,217,201,252,137,204,199,35,121,82,126,211,233,121,58,124,8,121,242,165,28,38,92,71,121,192,183,99,180,140,211,195,94,118,106,73,250,78,55,121,227,14,44,132,128,222,94,123,27,105,160,103,222,66,176,246,141,222,70,191,63,224,160,132,119,200,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("314059c6-f688-44bf-b84c-c7c747f99b73"));
		}

		#endregion

	}

	#endregion

}


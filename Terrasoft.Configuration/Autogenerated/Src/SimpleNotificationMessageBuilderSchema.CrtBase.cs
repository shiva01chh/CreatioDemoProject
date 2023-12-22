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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,75,107,27,49,16,62,59,144,255,48,184,23,27,130,221,94,237,58,208,4,146,238,193,109,192,205,205,80,20,107,188,22,236,74,139,164,109,49,139,255,123,71,143,125,165,212,222,144,250,98,105,102,190,121,124,243,105,37,203,209,20,108,135,240,3,181,102,70,237,237,236,94,201,189,72,75,205,172,80,242,250,170,186,190,26,149,70,200,20,54,71,99,49,95,54,247,22,178,70,99,88,74,54,2,231,185,146,20,67,81,31,52,166,148,2,238,51,102,204,2,54,34,47,50,252,166,172,216,139,157,79,30,96,120,87,138,140,163,246,152,162,124,201,196,14,118,14,114,17,1,11,72,206,229,27,85,62,103,211,200,131,192,140,83,39,79,90,252,98,22,131,179,8,23,208,200,184,146,217,49,86,141,185,224,103,30,15,43,144,248,187,239,156,76,151,177,0,74,30,106,244,11,62,105,85,160,182,2,93,81,63,89,240,207,231,115,248,108,202,60,103,250,120,91,27,30,209,26,80,26,140,251,23,28,37,13,70,51,170,61,216,3,130,187,218,227,172,65,207,187,240,200,218,99,41,56,36,28,220,202,70,163,20,237,210,31,76,60,156,222,88,92,180,213,25,207,133,132,82,10,59,160,3,210,201,23,23,255,76,225,255,161,27,73,26,173,251,112,116,250,85,131,85,32,221,234,47,80,98,172,118,82,253,222,224,222,219,141,161,85,183,188,68,113,12,234,97,19,144,231,27,248,151,146,214,104,15,138,15,145,145,87,191,1,86,247,214,217,230,128,221,121,116,194,39,211,216,167,70,91,106,249,106,165,23,25,251,171,135,3,61,174,75,245,147,181,73,191,250,184,128,15,231,166,147,142,59,100,163,23,89,63,206,89,112,4,70,99,173,72,247,42,242,190,236,142,115,104,195,223,52,198,139,226,195,244,230,145,119,20,253,154,200,224,159,61,40,157,51,59,25,87,21,108,199,26,119,74,19,233,219,241,130,110,213,199,211,118,124,67,135,70,235,100,39,243,39,50,159,78,228,73,248,77,171,231,233,240,33,100,231,75,57,76,184,142,242,128,111,198,104,24,167,135,189,106,213,178,236,59,221,228,181,59,176,16,2,122,123,237,109,164,134,158,121,11,193,218,55,122,91,247,247,7,168,23,169,47,209,6,0,0 };
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


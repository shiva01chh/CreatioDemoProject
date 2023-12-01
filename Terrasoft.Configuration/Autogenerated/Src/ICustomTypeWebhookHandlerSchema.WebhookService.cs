namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICustomTypeWebhookHandlerSchema

	/// <exclude/>
	public class ICustomTypeWebhookHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICustomTypeWebhookHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICustomTypeWebhookHandlerSchema(ICustomTypeWebhookHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("87741c9c-aa61-4ad0-b909-e56eff97f745");
			Name = "ICustomTypeWebhookHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c57d96f3-f6a9-41c3-a651-44ed58ea0c9a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,80,203,110,131,48,16,60,19,41,255,176,74,46,237,5,238,133,230,146,75,123,104,21,169,145,122,54,176,128,219,96,163,245,58,21,66,253,247,26,243,104,82,37,81,17,66,102,61,51,59,51,74,212,104,26,145,33,236,145,72,24,93,112,184,213,170,144,165,37,193,82,171,229,162,91,46,2,107,164,42,225,173,53,140,117,188,92,184,73,20,69,144,24,91,215,130,218,205,248,255,142,105,165,245,39,100,214,176,174,129,219,6,161,18,42,63,32,133,19,37,58,225,52,54,61,200,12,164,98,164,162,247,240,188,245,204,189,35,142,90,79,3,221,129,59,191,54,88,19,150,206,22,236,72,55,72,44,209,60,192,206,235,12,247,127,125,249,129,3,31,101,142,4,202,197,13,103,216,169,151,192,48,245,25,39,232,171,67,66,7,37,114,12,223,55,164,189,193,158,216,167,189,34,221,231,1,255,57,23,92,163,202,135,56,231,217,94,144,43,157,255,39,216,188,253,107,172,190,17,228,140,187,62,225,40,14,246,154,33,63,241,80,223,200,227,74,170,198,242,106,51,118,224,169,160,139,11,170,133,166,121,105,152,68,254,226,87,146,144,45,41,179,73,162,233,212,95,233,244,3,51,30,104,120,55,238,240,27,239,227,139,69,184,122,220,235,158,31,204,177,249,145,158,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("87741c9c-aa61-4ad0-b909-e56eff97f745"));
		}

		#endregion

	}

	#endregion

}


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationInfoHandlerSchema

	/// <exclude/>
	public class INotificationInfoHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationInfoHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationInfoHandlerSchema(INotificationInfoHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6fc817aa-1460-4964-9d28-c837ff664b7c");
			Name = "INotificationInfoHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,77,75,195,64,16,61,91,232,127,24,114,170,80,18,236,197,131,53,32,34,53,23,21,84,60,136,135,77,118,182,14,236,71,152,221,20,74,233,127,119,147,180,152,54,186,183,25,222,188,121,239,205,90,97,208,215,162,66,120,67,102,225,157,10,233,189,179,138,214,13,139,64,206,78,39,187,233,228,162,241,100,215,240,186,245,1,205,205,89,29,241,90,99,213,130,125,186,66,139,76,85,196,68,84,150,101,176,244,141,49,130,183,121,95,23,54,32,171,118,159,114,12,53,187,10,125,199,101,93,32,69,149,232,105,142,195,217,96,250,243,185,244,78,99,192,89,242,65,90,67,137,192,104,220,6,37,8,21,89,225,58,189,90,164,139,57,144,141,178,132,132,198,255,235,42,45,158,6,251,30,133,149,26,57,185,252,138,107,234,166,212,84,69,146,163,208,19,104,97,149,59,192,35,118,215,217,28,249,236,26,47,189,55,244,99,107,99,111,125,167,22,44,12,216,120,146,219,132,226,34,159,228,191,217,130,83,16,190,241,140,109,153,117,67,127,115,196,0,184,144,35,22,146,30,20,59,211,222,239,78,26,178,239,150,194,9,211,198,145,132,222,102,107,120,86,60,216,198,32,139,82,227,114,20,71,14,173,86,54,189,162,57,12,193,171,134,100,14,7,29,151,237,207,217,79,39,251,54,181,225,251,1,71,128,249,253,133,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6fc817aa-1460-4964-9d28-c837ff664b7c"));
		}

		#endregion

	}

	#endregion

}


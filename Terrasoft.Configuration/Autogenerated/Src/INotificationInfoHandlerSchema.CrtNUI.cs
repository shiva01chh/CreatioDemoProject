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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,77,75,195,64,16,61,91,232,127,24,114,170,80,18,236,197,131,53,32,34,53,23,21,84,60,136,135,109,118,182,14,236,71,152,221,20,74,233,127,119,55,105,177,109,116,111,51,188,121,243,222,155,181,194,160,111,68,141,240,134,204,194,59,21,242,123,103,21,173,90,22,129,156,29,143,182,227,209,69,235,201,174,224,117,227,3,154,155,179,58,226,181,198,58,129,125,190,64,139,76,117,196,68,84,81,20,48,247,173,49,130,55,101,95,87,54,32,171,180,79,57,134,134,93,141,190,227,178,46,144,162,90,244,52,135,225,226,104,250,243,121,233,157,198,128,147,236,131,180,134,37,2,163,113,107,148,32,84,100,133,235,252,106,150,207,166,64,54,202,18,18,90,255,175,171,188,122,58,218,247,40,172,212,200,217,229,87,92,211,180,75,77,117,36,57,8,61,129,86,86,185,61,60,98,183,157,205,129,207,174,241,210,123,67,63,180,54,244,214,119,26,193,194,128,141,39,185,205,40,46,242,89,249,155,45,56,5,225,27,207,216,230,69,55,244,55,71,12,128,43,57,96,33,233,65,177,51,233,126,119,210,144,125,183,20,78,152,214,142,36,244,54,147,225,73,245,96,91,131,44,150,26,231,131,56,74,72,90,217,244,138,166,112,12,94,180,36,75,216,235,184,76,63,103,55,30,237,82,106,233,253,0,166,231,107,131,125,2,0,0 };
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


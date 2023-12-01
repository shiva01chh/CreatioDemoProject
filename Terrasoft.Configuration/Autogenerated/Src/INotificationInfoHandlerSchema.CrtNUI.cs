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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,77,75,195,64,16,61,91,232,127,24,114,106,161,36,216,139,7,107,64,68,106,46,42,168,120,144,30,54,217,217,58,176,31,97,118,83,40,165,255,221,77,210,98,219,232,222,102,120,243,230,189,55,107,133,65,95,139,10,225,29,153,133,119,42,164,15,206,42,90,55,44,2,57,59,30,237,198,163,171,198,147,93,195,219,214,7,52,183,23,117,196,107,141,85,11,246,233,18,45,50,85,17,19,81,89,150,193,194,55,198,8,222,230,125,93,216,128,172,218,125,202,49,212,236,42,244,29,151,117,129,20,85,162,167,57,14,103,39,211,95,47,165,119,26,3,78,146,79,210,26,74,4,70,227,54,40,65,168,200,10,55,233,245,60,157,207,128,108,148,37,36,52,254,95,87,105,241,124,178,239,73,88,169,145,147,233,42,174,169,155,82,83,21,73,142,66,207,160,133,85,238,0,143,216,93,103,115,224,179,107,188,246,222,208,15,173,13,189,245,157,90,176,48,96,227,73,238,18,138,139,124,146,255,102,11,78,65,248,198,11,182,69,214,13,253,205,17,3,224,66,14,88,72,122,80,236,76,123,191,123,105,200,126,88,10,103,76,27,71,18,122,155,173,225,73,241,104,27,131,44,74,141,139,65,28,57,180,90,217,244,138,102,112,10,94,54,36,115,56,232,152,182,63,103,63,30,237,219,212,226,251,1,59,17,8,183,124,2,0,0 };
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


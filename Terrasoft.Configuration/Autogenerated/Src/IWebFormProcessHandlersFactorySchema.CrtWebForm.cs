namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IWebFormProcessHandlersFactorySchema

	/// <exclude/>
	public class IWebFormProcessHandlersFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IWebFormProcessHandlersFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IWebFormProcessHandlersFactorySchema(IWebFormProcessHandlersFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("30248ea6-6ed0-4ae8-b005-c4b54f120925");
			Name = "IWebFormProcessHandlersFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,83,193,106,195,48,12,61,183,208,127,16,237,101,131,145,220,219,44,151,177,118,57,12,10,235,216,217,141,149,212,144,216,65,182,25,97,236,223,103,59,109,214,52,133,13,118,91,78,214,147,244,164,247,236,72,86,163,110,88,142,176,67,34,166,85,97,162,7,37,11,81,90,98,70,40,57,155,126,204,166,19,171,133,44,225,165,213,6,235,213,69,236,234,171,10,115,95,172,163,13,74,36,145,127,215,156,211,18,58,220,101,22,132,165,171,134,76,26,164,194,13,95,66,246,134,251,181,162,122,75,42,71,173,159,152,228,21,146,94,179,220,40,106,67,87,28,199,144,104,91,215,140,218,244,24,31,243,80,40,130,18,141,241,19,155,142,2,14,71,14,224,216,160,228,62,229,102,86,172,59,54,172,68,64,105,132,105,163,19,121,124,198,222,216,125,37,114,16,167,21,127,220,112,226,125,234,165,61,163,57,40,174,151,176,13,60,65,192,72,65,0,54,104,52,152,3,186,189,113,180,123,212,183,197,151,125,73,195,136,213,32,221,5,222,207,173,70,114,215,38,187,107,152,167,59,199,231,49,200,123,48,74,226,208,113,157,224,189,19,151,241,174,215,133,222,211,26,4,247,30,21,2,105,220,79,104,44,73,157,38,241,233,228,83,217,163,180,53,18,219,87,152,100,225,57,48,131,188,55,15,135,254,165,94,255,8,213,55,175,3,65,48,212,119,231,231,76,54,86,112,232,247,190,93,253,202,99,165,205,255,55,217,137,188,230,242,8,254,131,205,11,247,71,117,79,61,196,159,221,127,61,0,3,118,254,125,1,210,206,219,33,108,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("30248ea6-6ed0-4ae8-b005-c4b54f120925"));
		}

		#endregion

	}

	#endregion

}


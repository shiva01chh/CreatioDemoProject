namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationFactorySchema

	/// <exclude/>
	public class INotificationFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationFactorySchema(INotificationFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("105f1ef7-143f-4c69-82ab-4aee819c63e5");
			Name = "INotificationFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,193,10,194,48,12,134,207,14,246,14,197,147,94,214,7,112,238,50,16,118,217,201,23,136,93,42,5,151,142,180,19,134,248,238,182,115,234,100,90,114,72,211,124,255,159,148,160,69,215,129,66,113,68,102,112,86,251,172,180,164,205,185,103,240,198,82,154,220,210,100,21,66,74,41,114,215,183,45,240,80,76,247,138,60,178,142,180,182,44,20,99,64,232,44,200,122,163,141,26,121,209,177,189,154,6,57,123,105,200,153,72,215,159,46,70,9,243,214,169,234,25,123,0,229,45,15,161,47,206,176,152,96,44,148,209,20,155,255,158,75,211,103,165,3,134,86,80,216,127,191,86,23,112,174,14,233,186,40,99,58,150,179,92,142,61,31,132,209,247,76,174,168,127,122,229,242,245,30,129,175,69,166,41,43,114,30,72,225,198,121,142,255,244,182,221,238,2,114,79,147,16,105,50,63,15,20,99,80,11,159,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("105f1ef7-143f-4c69-82ab-4aee819c63e5"));
		}

		#endregion

	}

	#endregion

}


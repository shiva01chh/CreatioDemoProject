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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,193,10,194,48,12,134,207,14,246,14,101,39,189,172,15,224,220,101,32,236,178,147,47,16,107,58,10,46,29,105,39,12,241,221,109,167,206,137,90,114,72,211,124,255,159,148,160,67,215,131,66,113,64,102,112,86,251,188,178,164,77,59,48,120,99,41,77,174,105,178,10,33,165,20,133,27,186,14,120,44,159,247,154,60,178,142,180,182,44,20,99,64,168,21,100,189,209,70,77,188,232,217,94,204,9,57,127,105,200,133,72,63,28,207,70,9,51,235,212,205,130,221,131,242,150,199,208,23,103,248,154,96,42,84,209,20,79,255,61,191,77,31,149,30,24,58,65,97,255,93,166,206,224,92,19,210,172,172,98,58,149,243,66,78,61,111,132,209,15,76,174,108,126,122,21,242,245,30,129,143,69,158,83,214,228,60,144,194,181,243,28,255,105,182,221,108,3,114,75,147,16,105,18,206,29,73,167,136,125,150,1,0,0 };
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


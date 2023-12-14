namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationHandlerSchema

	/// <exclude/>
	public class INotificationHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationHandlerSchema(INotificationHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f9c66d6e-bd4a-4fc2-8d6b-edbb5e21ba56");
			Name = "INotificationHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,144,193,78,195,48,12,134,207,171,212,119,136,118,130,203,242,0,43,189,32,4,189,160,73,219,11,120,153,51,44,37,78,229,36,72,211,196,187,147,182,3,86,26,249,18,219,255,247,219,102,240,24,123,48,168,14,40,2,49,216,180,121,14,108,233,156,5,18,5,174,171,107,93,173,114,36,62,171,253,37,38,244,165,238,28,154,161,24,55,175,200,40,100,182,117,85,186,180,214,170,137,217,123,144,75,123,251,119,156,80,236,96,96,131,168,94,130,193,56,194,56,36,178,100,96,226,252,168,245,157,188,207,71,71,70,209,47,161,123,191,211,188,1,159,28,74,233,27,6,92,120,143,137,221,100,135,113,233,182,180,155,50,61,8,120,197,229,44,79,235,153,104,221,254,237,173,130,85,233,3,255,81,27,61,138,71,214,103,160,147,154,70,124,232,94,56,123,20,56,58,108,102,43,116,108,67,59,135,60,150,75,174,190,234,170,196,240,190,1,32,221,74,86,159,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f9c66d6e-bd4a-4fc2-8d6b-edbb5e21ba56"));
		}

		#endregion

	}

	#endregion

}


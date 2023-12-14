namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImapFolderSchema

	/// <exclude/>
	public class IImapFolderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImapFolderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImapFolderSchema(IImapFolderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6310e556-8a63-4c49-b0b8-076bc13c50bb");
			Name = "IImapFolder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,142,65,10,194,48,16,69,215,13,244,14,3,238,61,64,221,74,161,160,69,170,23,136,205,180,14,164,73,153,68,93,20,239,110,76,80,90,212,217,205,127,255,207,124,35,7,116,163,108,17,78,200,44,157,237,252,122,47,73,231,98,202,69,46,178,21,99,79,214,64,101,60,114,23,124,5,84,213,32,199,210,106,133,28,45,227,245,172,169,5,122,59,150,134,44,221,249,28,42,9,181,114,5,28,98,42,49,231,153,76,15,117,232,2,19,244,232,55,240,152,233,199,139,101,255,15,110,81,211,64,225,245,47,216,200,251,87,46,244,132,26,157,15,124,135,55,212,51,24,123,162,81,169,106,220,147,186,20,131,246,154,39,66,183,105,91,59,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6310e556-8a63-4c49-b0b8-076bc13c50bb"));
		}

		#endregion

	}

	#endregion

}


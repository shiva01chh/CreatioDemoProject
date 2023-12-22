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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,142,65,10,194,48,16,69,215,45,244,14,3,238,61,64,221,74,33,160,69,212,11,196,118,90,7,210,36,76,162,46,138,119,55,36,40,41,234,236,230,191,255,103,190,150,19,58,43,59,132,51,50,75,103,6,191,222,75,82,85,57,87,101,85,22,43,198,145,140,6,161,61,242,16,124,53,8,49,73,219,24,213,35,71,139,189,93,20,117,64,111,199,210,80,164,59,159,67,13,161,234,93,13,135,152,74,204,121,38,61,66,27,186,192,12,35,250,13,60,51,253,116,53,236,255,193,45,42,154,40,188,254,5,143,242,241,149,11,61,161,69,231,3,223,225,29,85,6,99,79,212,125,170,26,247,164,46,197,160,229,243,2,248,215,251,45,67,1,0,0 };
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


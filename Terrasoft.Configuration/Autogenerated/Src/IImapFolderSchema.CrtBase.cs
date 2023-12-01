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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,142,65,10,194,48,16,69,215,45,244,14,3,238,61,64,221,74,161,160,69,212,11,196,118,90,7,210,36,76,162,46,138,119,119,72,80,90,212,217,205,127,255,207,124,163,70,244,78,181,8,103,100,86,222,246,97,189,87,164,139,124,42,242,34,207,86,140,3,89,3,181,9,200,189,248,74,168,235,81,185,202,234,14,57,90,220,237,162,169,5,122,59,150,134,44,221,249,28,170,8,117,231,75,56,196,84,98,62,48,153,1,26,233,2,19,12,24,54,240,156,233,167,171,229,240,15,110,81,211,72,242,250,23,60,170,199,87,78,122,66,131,62,8,223,225,29,245,12,198,158,104,186,84,53,238,73,93,138,162,201,188,0,147,47,115,184,58,1,0,0 };
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


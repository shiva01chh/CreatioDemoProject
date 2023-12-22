namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountRequestSchema

	/// <exclude/>
	public class AccountRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountRequestSchema(AccountRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c2254511-5ed7-2a4b-f1ee-949aba2a67b2");
			Name = "AccountRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,143,205,106,196,48,12,132,207,27,200,59,8,246,158,220,219,82,40,89,40,11,133,134,118,95,64,235,40,193,144,72,169,108,31,202,210,119,111,98,39,75,250,195,250,96,208,104,62,102,196,56,144,27,209,16,156,72,21,157,180,190,168,132,91,219,5,69,111,133,139,119,49,22,251,23,194,230,153,56,207,46,121,150,103,187,189,82,55,45,161,234,209,185,59,120,50,70,2,251,55,250,8,228,124,116,148,101,9,15,46,12,3,234,231,227,50,31,78,175,160,201,3,173,40,96,194,32,140,13,122,114,197,138,149,27,110,12,231,222,26,48,115,208,159,156,93,106,115,173,83,171,140,164,222,210,212,169,142,96,218,255,46,19,133,74,105,190,16,26,25,208,114,113,245,109,211,215,120,231,213,114,183,34,135,72,192,5,58,242,247,224,230,239,235,70,80,189,65,193,178,243,200,134,110,231,157,69,250,200,45,216,113,161,254,203,220,19,55,233,254,56,39,245,167,56,105,219,247,13,137,132,106,78,245,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c2254511-5ed7-2a4b-f1ee-949aba2a67b2"));
		}

		#endregion

	}

	#endregion

}


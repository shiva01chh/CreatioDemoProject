namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountConstsSchema

	/// <exclude/>
	public class AccountConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountConstsSchema(AccountConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a6894da9-d220-412d-8d46-9dc9c008ba69");
			Name = "AccountConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("912fb492-38c7-4dbe-88b2-46a261777d72");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,85,143,193,106,195,48,16,68,207,22,232,31,150,244,210,30,148,212,196,33,42,33,135,88,86,75,79,61,52,63,160,200,74,16,216,146,209,74,4,83,242,239,145,77,91,218,97,46,51,251,24,216,132,214,93,224,115,196,104,250,29,37,148,56,213,27,28,148,54,112,52,33,40,244,231,184,20,222,157,237,37,5,21,173,119,148,124,81,82,12,233,212,89,13,24,115,167,65,119,10,17,14,90,251,228,98,166,49,98,102,38,174,88,173,224,225,71,192,96,14,191,205,4,252,95,10,70,181,222,117,35,188,37,219,194,71,10,194,247,131,114,227,247,246,123,11,123,112,230,58,159,31,23,114,253,204,235,45,47,217,90,108,106,86,73,81,51,254,34,95,217,70,148,178,169,154,67,197,185,92,60,229,191,138,27,37,217,127,117,7,34,195,95,3,250,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a6894da9-d220-412d-8d46-9dc9c008ba69"));
		}

		#endregion

	}

	#endregion

}


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEntityFileCopierSchema

	/// <exclude/>
	public class IEntityFileCopierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEntityFileCopierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEntityFileCopierSchema(IEntityFileCopierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c02c3b56-5b96-4366-af70-1c204d27c6c2");
			Name = "IEntityFileCopier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c85d2d65-6230-4aeb-9934-bfac9785d42f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,77,106,195,48,16,133,215,9,228,14,67,186,105,161,216,251,36,13,148,208,150,44,82,74,146,11,168,242,200,22,88,63,29,73,45,38,244,238,149,101,39,36,193,180,212,43,207,155,231,79,79,51,214,76,161,179,140,35,236,145,136,57,35,124,182,50,90,200,50,16,243,210,232,201,248,48,25,143,130,147,186,132,93,227,60,170,249,100,28,149,27,194,50,182,97,173,61,146,136,128,25,172,159,180,151,190,121,150,53,174,140,149,72,201,152,231,57,44,92,80,138,81,179,236,235,45,90,66,135,218,59,224,70,123,98,220,131,48,20,11,219,180,7,97,2,129,136,36,7,95,210,87,224,44,114,41,36,7,99,219,84,46,59,146,243,51,180,13,239,117,180,200,99,164,161,68,163,67,74,117,202,191,65,95,153,194,205,224,45,125,220,53,175,51,39,33,18,26,96,117,221,199,18,100,20,24,141,199,176,222,0,211,198,87,72,217,9,145,95,51,22,150,17,83,160,227,212,31,166,206,4,226,184,97,113,168,180,227,21,42,246,26,245,233,178,123,79,38,48,2,58,27,168,228,235,79,203,22,121,34,253,13,222,34,55,84,172,139,136,189,224,80,210,33,104,249,17,80,22,45,86,196,1,253,14,246,140,74,244,215,224,125,82,255,3,254,52,178,72,243,124,172,235,91,231,169,221,249,240,52,238,225,37,68,239,208,141,250,214,80,166,187,121,191,100,212,69,183,231,84,127,119,127,238,133,24,181,243,231,7,124,93,170,99,16,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c02c3b56-5b96-4366-af70-1c204d27c6c2"));
		}

		#endregion

	}

	#endregion

}


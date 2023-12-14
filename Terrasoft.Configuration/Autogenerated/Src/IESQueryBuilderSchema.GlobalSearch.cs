namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IESQueryBuilderSchema

	/// <exclude/>
	public class IESQueryBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IESQueryBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IESQueryBuilderSchema(IESQueryBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("88313c62-0396-406c-abf5-3debda333fb2");
			Name = "IESQueryBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c3a921b-299a-4f38-a040-5c0154a25bee");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,145,177,110,131,48,16,134,231,32,241,14,86,186,180,11,222,19,202,144,42,138,50,84,74,69,95,224,128,131,88,50,54,57,219,67,84,245,221,107,108,72,72,202,132,143,255,187,251,124,40,232,209,12,80,35,251,70,34,48,186,181,217,135,86,173,232,28,129,21,90,101,7,169,43,144,37,2,213,231,52,249,73,147,52,89,57,35,84,183,32,246,18,140,21,117,12,109,67,228,133,176,243,56,59,42,139,212,250,1,27,118,220,151,95,14,233,186,115,66,54,72,33,198,57,103,185,113,125,15,116,45,166,243,212,141,153,208,142,93,70,134,85,51,20,17,190,96,6,87,73,31,23,243,164,255,131,86,81,251,38,245,137,246,172,27,179,97,167,128,198,143,207,42,161,16,90,24,134,147,82,116,105,73,247,222,78,98,109,99,37,187,241,252,185,65,62,0,65,207,148,223,243,251,58,222,40,184,173,139,114,113,189,44,231,33,119,199,8,173,35,101,138,19,116,8,149,196,71,5,159,159,3,35,49,135,166,205,133,1,81,61,188,190,150,247,185,108,225,240,182,157,214,130,170,137,155,9,231,223,248,3,31,138,190,54,62,127,48,55,190,168,47,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("88313c62-0396-406c-abf5-3debda333fb2"));
		}

		#endregion

	}

	#endregion

}


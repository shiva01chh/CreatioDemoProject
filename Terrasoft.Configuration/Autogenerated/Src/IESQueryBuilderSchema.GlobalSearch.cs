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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,145,191,110,131,48,16,135,231,32,241,14,86,186,180,11,222,19,202,144,42,170,50,84,74,69,95,224,128,131,88,242,31,122,182,135,168,234,187,215,177,33,33,41,19,62,126,223,221,231,67,131,66,59,66,139,236,11,137,192,154,222,21,111,70,247,98,240,4,78,24,93,188,75,211,128,172,17,168,61,229,217,79,158,229,217,202,91,161,135,5,177,151,96,157,104,83,104,27,35,79,132,67,192,217,65,59,164,62,12,216,176,195,190,254,244,72,231,157,23,178,67,138,49,206,57,43,173,87,10,232,92,77,231,169,27,179,177,29,251,190,48,172,153,161,132,240,5,51,250,70,134,184,152,39,253,31,180,74,218,87,169,15,116,39,211,217,13,59,70,52,125,124,84,137,133,216,194,50,156,148,146,75,79,70,5,59,137,173,75,149,226,202,243,199,6,229,8,4,138,233,176,231,215,117,186,81,116,91,87,245,226,122,69,201,99,238,134,17,58,79,218,86,71,24,16,26,137,247,10,33,63,7,46,196,28,154,54,23,7,36,245,248,250,92,223,230,178,133,195,203,118,90,11,234,46,109,38,158,127,211,15,188,43,134,218,242,249,3,253,173,55,75,55,2,0,0 };
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


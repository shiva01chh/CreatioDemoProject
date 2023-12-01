namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IESMentionQueryBuilderSchema

	/// <exclude/>
	public class IESMentionQueryBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IESMentionQueryBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IESMentionQueryBuilderSchema(IESMentionQueryBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8a92e121-7675-4439-bb61-e6af58efe391");
			Name = "IESMentionQueryBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f0db0304-dc6c-40c0-a3bb-97ab97632500");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,146,193,110,131,48,12,134,207,67,234,59,88,236,178,93,200,189,165,28,54,85,83,15,149,182,117,47,96,192,208,72,16,152,147,28,170,106,239,190,144,0,163,213,54,110,249,227,239,255,109,7,133,45,233,30,11,130,15,98,70,221,85,38,121,238,84,37,107,203,104,100,167,146,151,166,203,177,57,18,114,113,90,69,151,85,116,103,181,84,245,162,126,89,145,236,149,33,174,156,161,222,172,34,87,124,207,84,59,27,152,245,53,236,119,199,3,169,193,252,205,18,159,159,172,108,74,98,95,45,132,128,84,219,182,69,62,103,227,121,215,160,54,178,0,237,3,160,13,40,124,14,44,228,1,78,38,86,44,224,222,230,141,227,228,148,252,71,48,92,124,244,220,233,129,204,169,43,245,26,94,61,31,46,111,27,243,130,55,112,50,17,20,76,213,54,94,186,199,34,131,170,227,177,237,97,99,37,26,212,174,29,160,171,137,146,217,95,220,6,164,61,50,182,160,220,35,109,99,63,112,156,253,19,39,149,54,168,10,74,82,225,193,31,31,38,99,89,233,37,60,174,245,55,120,170,30,240,240,172,239,228,210,181,9,19,123,228,97,25,30,30,227,113,51,46,146,84,25,118,57,156,157,242,21,254,132,43,217,105,238,251,6,154,21,97,22,127,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8a92e121-7675-4439-bb61-e6af58efe391"));
		}

		#endregion

	}

	#endregion

}


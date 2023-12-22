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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,146,193,78,195,48,12,134,207,84,218,59,88,229,2,151,230,190,117,59,128,38,180,195,36,96,188,128,219,186,93,164,54,45,78,114,152,38,222,157,52,233,74,54,1,189,229,143,191,255,183,157,42,236,72,15,88,18,124,16,51,234,190,54,217,115,175,106,217,88,70,35,123,149,189,180,125,129,237,129,144,203,227,34,57,47,146,59,171,165,106,162,250,184,34,219,41,67,92,59,67,189,90,36,174,248,158,169,113,54,48,235,75,216,109,15,123,82,163,249,155,37,62,61,89,217,86,196,190,90,8,1,185,182,93,135,124,218,76,231,109,139,218,200,18,180,15,128,46,160,240,57,178,80,4,56,187,176,34,130,7,91,180,142,147,151,228,63,130,225,236,163,231,78,247,100,142,125,165,151,240,234,249,112,121,219,152,23,188,129,147,137,160,100,170,215,105,236,158,138,13,212,61,79,109,143,27,171,208,160,118,237,0,93,77,148,205,254,226,54,32,31,144,177,3,229,30,105,157,250,129,211,205,63,113,82,105,131,170,164,44,23,30,252,241,97,50,150,149,142,225,105,173,191,193,151,234,17,15,207,250,78,46,93,155,48,177,71,30,226,240,240,24,143,171,105,145,164,170,176,203,241,236,148,175,240,39,92,201,78,139,191,111,111,211,2,70,136,2,0,0 };
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


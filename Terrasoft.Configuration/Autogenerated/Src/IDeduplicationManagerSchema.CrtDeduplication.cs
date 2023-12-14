namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDeduplicationManagerSchema

	/// <exclude/>
	public class IDeduplicationManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDeduplicationManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDeduplicationManagerSchema(IDeduplicationManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f3e391f5-bea4-4635-974c-b28b77b1e29d");
			Name = "IDeduplicationManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,83,77,111,194,48,12,61,23,137,255,96,177,11,147,166,246,14,93,47,99,76,28,144,38,216,31,8,173,219,69,106,210,206,73,38,33,180,255,62,147,126,13,196,24,135,245,210,218,126,239,217,126,77,180,80,104,106,145,34,188,33,145,48,85,110,195,167,74,231,178,112,36,172,172,116,184,192,204,213,165,76,125,52,30,29,198,163,192,25,169,11,216,238,141,69,53,63,139,153,93,150,152,30,193,38,124,65,141,36,83,198,48,234,142,176,224,44,172,180,69,202,185,229,12,86,39,226,107,161,69,129,228,193,81,20,65,108,156,82,130,246,73,27,159,128,65,53,232,176,3,71,63,208,181,219,49,14,100,215,233,183,70,193,193,55,235,71,91,163,125,175,50,51,131,87,47,208,20,207,71,241,137,165,212,153,129,78,19,13,48,219,136,79,12,123,70,116,78,137,107,65,66,129,102,199,31,39,57,243,23,61,123,131,31,14,141,157,36,237,71,24,71,30,60,112,9,173,35,109,146,129,3,105,111,52,195,187,250,145,176,122,214,78,33,137,93,137,241,66,122,4,207,17,27,75,252,155,30,160,121,39,137,223,97,208,155,46,47,141,4,23,7,189,159,255,105,141,145,74,150,130,128,48,173,136,227,156,42,197,173,43,194,12,80,91,105,247,183,90,69,55,155,179,109,123,122,125,249,95,22,181,170,155,102,145,37,239,177,245,107,76,175,21,59,251,104,48,44,8,252,81,67,157,53,167,205,91,248,213,92,141,147,36,231,142,207,55,118,97,31,118,155,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f3e391f5-bea4-4635-974c-b28b77b1e29d"));
		}

		#endregion

	}

	#endregion

}


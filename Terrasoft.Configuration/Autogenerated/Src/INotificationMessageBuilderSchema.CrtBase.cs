namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationMessageBuilderSchema

	/// <exclude/>
	public class INotificationMessageBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationMessageBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationMessageBuilderSchema(INotificationMessageBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b0a82eba-e0ad-4ba7-bced-e8d42f2a5640");
			Name = "INotificationMessageBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,207,110,194,48,12,198,207,69,226,29,44,237,178,93,232,29,166,73,99,7,214,3,19,210,182,7,8,196,109,35,145,4,197,206,36,132,246,238,203,31,232,10,82,17,244,82,199,241,247,249,23,39,70,104,164,157,216,32,124,161,115,130,108,205,147,55,107,106,213,120,39,88,89,51,30,29,198,163,194,147,50,13,124,238,137,81,207,186,245,191,100,137,68,162,9,185,32,214,218,154,80,19,170,30,28,54,193,2,42,195,232,234,208,100,10,213,135,101,85,171,77,242,206,42,156,123,181,149,232,146,164,44,75,120,38,175,181,112,251,151,227,122,229,236,143,146,72,160,145,91,43,9,216,194,58,106,192,244,204,194,110,114,155,156,92,202,158,205,206,175,183,106,3,234,4,114,157,163,56,36,150,142,63,0,236,208,177,66,154,194,42,57,229,253,75,216,148,88,32,19,88,7,20,255,1,219,196,62,232,192,214,192,45,130,144,90,25,240,70,241,164,179,232,147,22,11,175,100,156,244,107,44,252,14,117,149,132,120,5,69,209,32,207,82,64,199,224,247,136,137,70,102,210,115,236,101,30,215,13,204,233,228,4,226,52,195,30,247,53,202,36,171,228,227,211,236,30,239,22,133,28,244,173,150,212,188,167,130,44,204,241,157,29,214,86,238,7,252,137,93,124,185,73,50,15,101,55,58,15,61,180,129,19,100,97,231,125,113,65,249,218,206,147,41,215,255,254,0,87,245,151,159,153,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b0a82eba-e0ad-4ba7-bced-e8d42f2a5640"));
		}

		#endregion

	}

	#endregion

}


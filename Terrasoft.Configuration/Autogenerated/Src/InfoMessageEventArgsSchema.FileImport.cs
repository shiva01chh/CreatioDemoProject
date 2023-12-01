namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: InfoMessageEventArgsSchema

	/// <exclude/>
	public class InfoMessageEventArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public InfoMessageEventArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public InfoMessageEventArgsSchema(InfoMessageEventArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("581d1ca8-4c25-474e-9e2b-79fe22e7b14e");
			Name = "InfoMessageEventArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1a247561-b87d-48fb-9e13-b6a8baa960d3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,81,203,10,194,48,16,60,91,232,63,44,120,247,3,244,36,82,165,7,161,80,127,32,182,219,16,104,147,176,155,136,34,254,187,73,171,226,35,39,115,8,201,48,59,147,153,104,49,32,91,209,32,28,144,72,176,233,220,98,99,116,167,164,39,225,148,209,139,173,234,177,28,172,33,151,103,215,60,155,121,86,90,66,125,97,135,195,42,207,2,50,39,148,129,9,176,233,5,243,18,10,34,67,123,100,22,18,139,19,106,183,38,201,35,211,250,99,175,26,104,34,47,77,131,37,148,186,51,191,211,179,232,253,178,170,200,88,36,167,48,216,85,163,232,168,255,52,216,121,213,194,244,232,58,40,133,137,178,133,43,72,116,43,224,184,221,62,232,197,185,65,27,195,190,157,18,236,57,234,118,242,15,183,9,123,135,18,77,164,163,124,23,145,98,133,30,254,13,207,142,226,15,61,20,255,8,50,34,97,221,1,254,106,34,148,28,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("581d1ca8-4c25-474e-9e2b-79fe22e7b14e"));
		}

		#endregion

	}

	#endregion

}


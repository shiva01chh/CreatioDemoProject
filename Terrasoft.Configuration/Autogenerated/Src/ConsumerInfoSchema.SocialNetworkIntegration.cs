namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ConsumerInfoSchema

	/// <exclude/>
	public class ConsumerInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ConsumerInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ConsumerInfoSchema(ConsumerInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("12a01026-e84b-495c-b275-01c91bdee21b");
			Name = "ConsumerInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4e5fe717-963e-416c-b3c1-b2bb720a6449");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,144,65,75,196,48,16,133,207,45,244,63,132,221,139,94,250,3,92,60,173,23,17,101,177,226,69,60,100,227,107,9,54,73,153,153,10,117,241,191,59,77,85,80,86,4,115,154,188,247,230,11,47,209,6,240,96,29,204,29,136,44,167,86,234,109,138,173,239,70,178,226,83,172,155,228,188,237,171,242,80,149,197,200,62,118,166,153,88,16,234,219,49,138,15,168,27,144,6,252,107,142,111,170,82,115,107,66,167,23,179,237,45,243,153,81,32,143,1,116,25,219,148,253,135,11,43,86,85,33,235,228,81,133,97,220,247,222,25,55,231,127,196,139,67,94,249,98,238,40,13,32,241,80,240,46,175,45,126,102,94,35,236,65,39,55,218,202,156,155,213,51,166,213,233,204,255,124,128,133,230,6,87,152,204,220,167,40,58,200,38,15,252,49,188,253,78,99,56,130,28,5,54,217,250,7,243,5,196,218,234,40,244,126,241,254,160,174,17,159,150,175,201,247,69,253,46,170,166,231,29,12,71,19,126,235,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("12a01026-e84b-495c-b275-01c91bdee21b"));
		}

		#endregion

	}

	#endregion

}


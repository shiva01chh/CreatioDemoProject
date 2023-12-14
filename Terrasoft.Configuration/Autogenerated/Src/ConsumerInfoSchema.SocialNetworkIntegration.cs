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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,144,65,75,196,48,16,133,207,45,244,63,132,221,139,94,250,3,92,60,173,23,17,101,177,226,69,60,204,198,105,9,54,73,153,153,8,117,241,191,59,73,85,80,86,4,115,154,188,247,230,11,47,1,60,242,4,22,205,29,18,1,199,94,218,109,12,189,27,18,129,184,24,218,46,90,7,99,83,31,154,186,74,236,194,96,186,153,5,125,123,155,130,56,143,109,135,164,1,247,90,226,155,166,214,220,154,112,208,139,217,142,192,124,102,20,200,201,35,93,134,62,22,255,225,2,4,84,21,2,43,143,42,76,105,63,58,107,108,206,255,136,87,135,178,242,197,220,81,156,144,196,161,130,119,101,109,241,11,243,26,253,30,233,228,70,91,153,115,179,122,198,121,117,154,249,159,15,176,80,110,112,133,179,201,125,170,106,64,217,148,129,63,134,183,223,105,140,150,80,142,2,187,98,253,131,249,130,196,218,234,40,244,126,241,254,160,174,49,60,45,95,83,238,139,250,93,84,45,159,119,255,89,31,59,236,1,0,0 };
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


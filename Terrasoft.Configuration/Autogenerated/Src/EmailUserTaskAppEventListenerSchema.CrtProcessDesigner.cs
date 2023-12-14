namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailUserTaskAppEventListenerSchema

	/// <exclude/>
	public class EmailUserTaskAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailUserTaskAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailUserTaskAppEventListenerSchema(EmailUserTaskAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b705c5b2-4b1a-4681-ad77-4eae6a95afd7");
			Name = "EmailUserTaskAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("da7de29a-d2b3-4248-bf8e-b7a592dc81f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,144,193,106,2,65,12,134,207,187,176,239,16,240,82,47,62,128,158,138,236,65,176,40,168,120,30,103,227,58,116,55,179,36,89,17,74,223,221,56,91,139,80,90,138,115,25,146,249,255,255,203,132,92,139,210,57,143,176,69,102,39,241,168,147,121,100,156,172,57,122,20,177,130,142,161,238,217,105,136,84,228,31,69,94,228,89,47,129,234,7,199,30,15,38,108,219,72,179,244,62,98,172,77,14,243,198,137,76,161,108,93,104,118,130,188,117,242,254,218,117,229,25,73,151,65,20,9,57,25,186,254,208,4,15,254,166,255,91,14,83,88,252,140,200,108,174,236,27,251,134,122,138,149,129,215,41,54,17,238,136,115,12,21,172,200,34,54,234,88,95,238,89,246,79,197,139,130,31,238,49,164,196,207,95,188,37,85,207,56,55,182,81,27,240,105,242,151,255,223,244,17,82,53,236,196,170,161,247,216,42,114,235,221,206,21,34,229,62,247,6,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b705c5b2-4b1a-4681-ad77-4eae6a95afd7"));
		}

		#endregion

	}

	#endregion

}


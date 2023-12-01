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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,144,193,106,2,65,12,134,207,187,176,239,16,240,82,47,62,128,61,21,217,67,193,82,65,165,231,113,54,110,7,119,51,75,146,21,161,244,221,27,103,85,4,169,136,115,25,146,249,255,255,203,132,92,139,210,57,143,176,66,102,39,113,171,147,89,100,156,44,56,122,20,177,130,182,161,238,217,105,136,84,228,63,69,94,228,89,47,129,234,43,199,23,110,76,216,182,145,94,211,251,136,177,54,57,204,26,39,50,133,178,117,161,89,11,242,202,201,238,173,235,202,61,146,206,131,40,18,114,50,116,253,166,9,30,252,81,127,95,14,83,120,191,141,200,108,174,236,130,253,64,253,142,149,129,23,41,54,17,206,136,125,12,21,124,146,69,44,213,177,190,156,179,236,159,138,7,5,63,220,99,72,137,191,255,120,75,170,158,113,46,109,163,54,224,211,228,147,255,97,250,8,169,26,118,98,213,208,187,110,21,185,245,236,252,1,184,15,216,83,5,2,0,0 };
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


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OperatorLogoutEventHandlerSchema

	/// <exclude/>
	public class OperatorLogoutEventHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OperatorLogoutEventHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OperatorLogoutEventHandlerSchema(OperatorLogoutEventHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c46064d2-8bfb-8ae3-a732-e51330addf7c");
			Name = "OperatorLogoutEventHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("01343ce8-0448-497f-b2c3-9511b4580fa3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,203,78,195,48,16,60,23,137,127,88,149,75,42,33,231,14,148,3,5,68,37,10,72,133,19,226,176,216,155,212,82,98,71,126,20,170,170,255,206,198,77,75,11,148,92,98,175,103,118,188,227,49,88,147,111,80,18,60,147,115,232,109,17,196,200,154,66,151,209,97,208,214,136,199,218,104,57,67,99,168,18,19,242,30,75,109,202,227,163,229,241,81,47,122,94,194,116,225,3,213,231,219,253,110,35,71,135,234,226,22,101,176,78,147,103,4,99,78,28,149,44,7,163,10,189,63,131,199,134,88,223,186,123,91,218,24,110,230,100,194,29,26,85,145,75,232,60,207,225,194,199,186,70,183,184,236,246,83,10,96,59,26,248,128,129,128,251,69,79,14,170,212,69,108,136,249,15,230,133,39,194,202,91,144,142,138,97,127,252,91,180,159,95,182,236,215,107,42,48,86,225,74,27,197,35,101,97,209,144,45,178,63,8,131,83,120,96,107,97,8,253,195,163,244,7,111,220,180,137,239,149,150,32,219,193,255,153,27,206,224,15,29,230,47,147,35,91,3,39,20,102,86,177,133,79,169,239,250,48,77,169,205,140,156,14,202,202,195,131,138,245,63,149,178,23,246,142,195,96,72,182,73,24,176,9,109,175,238,190,115,171,21,28,70,67,148,3,104,67,210,235,5,183,232,86,189,57,58,144,209,57,198,183,240,177,98,131,162,20,163,239,146,24,171,243,111,236,230,61,39,104,176,100,15,134,96,232,99,107,82,87,205,88,170,227,252,192,139,17,7,183,164,13,126,218,134,34,219,211,63,133,157,124,111,227,205,99,248,224,197,30,79,140,13,39,86,207,137,227,171,168,19,92,129,196,32,103,144,221,124,74,106,146,75,176,132,85,123,182,234,158,133,140,90,191,76,218,175,171,251,197,84,227,239,11,95,190,25,197,140,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c46064d2-8bfb-8ae3-a732-e51330addf7c"));
		}

		#endregion

	}

	#endregion

}


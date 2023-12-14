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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,77,79,227,48,16,61,23,137,255,48,234,94,82,9,57,119,160,28,40,32,42,209,101,165,238,158,16,135,193,158,164,150,18,59,242,71,119,171,170,255,125,199,110,90,90,160,228,18,123,252,222,60,207,243,51,216,146,239,80,18,252,38,231,208,219,42,136,137,53,149,174,163,195,160,173,17,207,173,209,114,129,198,80,35,102,228,61,214,218,212,231,103,235,243,179,65,244,188,132,249,202,7,106,175,246,251,195,70,142,78,213,197,3,202,96,157,38,207,8,198,252,112,84,179,28,76,26,244,254,18,158,59,98,125,235,158,108,109,99,184,95,146,9,143,104,84,67,46,163,203,178,132,107,31,219,22,221,234,166,223,207,41,128,237,105,224,3,6,2,238,23,61,57,104,114,23,177,35,150,31,152,215,158,8,27,111,65,58,170,198,195,233,103,209,97,121,147,216,47,119,84,97,108,194,173,54,138,71,42,194,170,35,91,21,95,16,70,23,240,147,173,133,49,12,79,143,50,28,189,114,211,46,190,53,90,130,76,131,127,51,55,92,194,23,58,204,95,103,71,246,6,206,40,44,172,98,11,127,229,190,219,195,60,165,54,11,114,58,40,43,79,15,42,182,255,92,42,254,176,119,28,6,67,50,37,97,196,38,164,94,253,125,151,86,43,56,141,134,40,71,144,66,50,24,4,183,234,87,131,37,58,144,209,57,198,39,248,84,177,65,81,138,201,123,73,76,213,213,59,118,247,158,51,52,88,179,7,99,48,244,119,111,82,95,45,88,170,231,124,192,139,9,7,183,166,29,126,158,66,81,28,233,95,192,65,190,247,241,230,49,124,240,226,136,39,166,134,19,171,151,196,241,85,212,11,110,64,98,144,11,40,238,255,73,234,178,75,176,134,77,58,219,244,207,66,70,109,95,38,239,183,213,227,98,174,165,239,63,72,83,198,201,141,3,0,0 };
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


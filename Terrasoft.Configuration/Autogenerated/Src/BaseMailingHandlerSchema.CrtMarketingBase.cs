namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseMailingHandlerSchema

	/// <exclude/>
	public class BaseMailingHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseMailingHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseMailingHandlerSchema(BaseMailingHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c034f568-64d4-4b23-8e61-b1ebaf6fc883");
			Name = "BaseMailingHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0a66fb70-43c4-43cd-a81c-f036ca2264c0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,219,110,219,48,12,125,118,129,254,3,145,189,180,64,97,191,215,105,128,45,195,178,14,232,16,172,235,7,200,50,147,168,144,37,67,151,0,65,208,127,31,45,201,174,157,173,233,154,55,145,135,60,135,228,113,20,107,208,182,140,35,252,70,99,152,213,27,151,47,181,218,136,173,55,204,9,173,46,47,142,151,23,153,183,66,109,225,241,96,29,54,148,151,18,121,151,180,249,10,21,26,193,203,1,51,110,99,240,173,120,254,200,119,88,123,137,134,16,132,249,100,112,75,253,96,41,153,181,183,240,133,89,124,96,66,82,225,119,166,106,130,5,84,81,20,48,183,190,105,152,57,44,210,187,131,66,19,177,176,139,224,188,199,22,35,112,235,43,41,56,176,202,58,195,184,3,222,81,253,131,9,110,225,254,148,59,59,6,254,65,230,55,129,178,38,157,107,35,246,204,97,76,182,241,1,6,89,173,149,60,0,17,117,162,158,117,181,50,218,183,63,105,213,112,7,179,212,124,86,166,158,168,234,216,118,202,177,54,186,69,227,4,6,30,237,104,227,88,247,76,233,249,58,77,226,34,32,71,107,3,85,119,183,44,219,162,235,142,144,189,188,87,250,67,87,255,83,182,23,198,121,38,71,85,175,195,13,165,112,164,45,56,111,212,100,248,18,94,70,45,223,154,251,1,221,78,215,231,134,238,37,124,21,193,132,116,223,121,84,115,3,186,122,38,204,2,86,232,214,204,16,167,67,99,175,158,44,26,50,181,138,166,5,63,121,94,39,217,73,176,242,82,150,31,146,25,124,21,147,167,6,13,129,37,25,194,161,5,161,172,99,138,190,52,189,1,183,195,177,89,255,118,107,140,180,221,12,160,104,142,187,217,84,245,108,113,63,106,215,229,128,15,201,124,94,132,202,208,232,212,247,123,45,234,164,169,111,241,206,130,202,51,195,253,194,70,239,63,60,92,210,212,31,50,72,138,157,6,73,253,89,62,183,237,240,95,145,71,12,121,238,42,185,245,102,98,192,235,51,135,139,209,105,48,196,198,191,63,32,195,117,202,14,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c034f568-64d4-4b23-8e61-b1ebaf6fc883"));
		}

		#endregion

	}

	#endregion

}


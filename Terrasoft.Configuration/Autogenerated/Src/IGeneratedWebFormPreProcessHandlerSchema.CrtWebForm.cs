namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IGeneratedWebFormPreProcessHandlerSchema

	/// <exclude/>
	public class IGeneratedWebFormPreProcessHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IGeneratedWebFormPreProcessHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IGeneratedWebFormPreProcessHandlerSchema(IGeneratedWebFormPreProcessHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3ffd2b0a-1f40-4b13-b22b-9f7c569366fc");
			Name = "IGeneratedWebFormPreProcessHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,77,107,195,48,12,61,183,208,255,32,218,203,6,37,185,111,93,47,219,218,229,80,40,172,99,103,55,81,82,67,99,27,217,233,54,198,254,251,228,124,53,105,202,22,48,68,47,122,146,222,179,162,68,142,214,136,24,97,135,68,194,234,212,5,143,90,165,50,43,72,56,169,213,100,252,61,25,143,10,43,85,214,75,33,188,191,138,119,168,193,26,21,242,43,38,239,184,95,105,202,95,145,78,50,246,68,166,206,8,51,78,130,72,57,164,148,39,184,131,232,146,176,37,220,146,142,209,218,23,161,146,35,82,201,12,195,16,22,182,200,115,65,95,203,58,230,180,147,76,208,130,108,202,65,170,9,12,33,159,178,130,31,84,167,224,14,200,57,166,112,96,4,137,220,66,74,58,135,35,151,247,9,70,100,24,52,45,194,78,15,83,236,143,50,238,84,255,127,86,184,42,168,175,102,228,205,109,173,216,160,59,232,196,150,34,7,42,75,224,249,19,227,194,177,76,47,195,159,11,129,94,179,53,24,203,84,98,50,80,53,148,85,33,165,19,160,120,21,30,166,133,69,226,91,84,24,251,43,156,46,119,220,196,99,16,183,96,176,8,75,198,245,2,60,66,254,36,156,168,168,62,130,132,195,191,73,31,149,61,27,97,144,42,98,249,21,217,109,11,89,101,162,166,97,13,66,87,144,178,45,80,251,203,218,207,141,207,194,187,217,171,122,204,198,210,155,183,158,112,232,251,48,135,54,191,209,55,7,95,102,20,213,55,27,229,70,147,219,150,59,181,110,6,174,119,172,141,111,171,213,31,205,80,37,213,157,115,244,83,253,14,29,104,50,102,204,63,191,60,245,15,139,158,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3ffd2b0a-1f40-4b13-b22b-9f7c569366fc"));
		}

		#endregion

	}

	#endregion

}


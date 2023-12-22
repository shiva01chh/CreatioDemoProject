namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITranslationActualizerSchema

	/// <exclude/>
	public class ITranslationActualizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITranslationActualizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITranslationActualizerSchema(ITranslationActualizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e2bd260d-8139-4e57-b269-fae5dc20c315");
			Name = "ITranslationActualizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d72ca66-8680-4c3f-b4a0-15ba7a19db7c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,193,106,194,64,16,61,43,248,15,131,189,232,37,185,171,21,196,90,42,180,80,48,180,231,53,153,196,133,100,87,102,39,130,149,254,123,55,155,38,110,172,22,115,74,102,222,188,55,239,101,148,40,208,236,69,140,16,33,145,48,58,229,96,169,85,42,179,146,4,75,173,130,136,132,50,185,123,31,244,79,131,126,175,52,82,101,176,57,26,198,98,218,126,251,227,132,193,74,177,100,137,198,2,44,228,129,48,179,243,176,86,140,148,90,181,9,172,61,222,69,204,165,200,229,23,146,67,239,203,109,46,99,144,13,248,38,182,119,114,248,150,126,117,64,197,102,2,239,142,160,238,97,85,171,59,47,66,37,57,210,236,147,36,227,171,142,43,26,177,205,241,67,228,37,58,196,130,50,51,135,235,125,34,77,211,95,61,84,73,45,217,213,127,67,222,233,228,98,129,48,12,97,102,202,162,16,116,156,55,133,214,133,1,62,123,11,90,124,120,57,48,219,11,18,5,40,251,187,30,135,162,153,126,38,93,12,231,209,14,33,17,140,192,26,12,11,98,104,0,142,21,82,139,10,102,161,99,112,132,7,45,147,243,10,94,184,163,39,75,19,201,2,161,35,49,158,222,103,37,63,103,6,135,42,52,115,195,81,119,129,203,168,205,232,95,193,13,114,39,181,202,51,227,189,217,121,131,54,57,47,251,63,1,89,157,181,241,16,203,157,80,25,38,35,119,218,71,127,131,241,245,187,248,174,111,191,83,116,53,255,249,1,188,24,141,31,129,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e2bd260d-8139-4e57-b269-fae5dc20c315"));
		}

		#endregion

	}

	#endregion

}


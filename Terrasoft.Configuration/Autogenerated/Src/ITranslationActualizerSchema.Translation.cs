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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,193,106,194,64,16,61,43,248,15,131,189,232,37,185,171,21,196,90,42,180,80,80,218,243,152,76,226,66,178,43,179,19,193,74,255,189,155,77,141,137,213,98,78,201,204,155,247,230,189,140,198,156,236,14,35,130,53,49,163,53,137,4,115,163,19,149,22,140,162,140,14,214,140,218,102,254,189,215,61,246,186,157,194,42,157,194,234,96,133,242,113,253,221,28,103,10,22,90,148,40,178,14,224,32,15,76,169,155,135,165,22,226,196,169,141,96,217,224,157,69,82,96,166,190,136,61,122,87,108,50,21,129,58,129,111,98,59,71,143,175,233,23,123,210,98,71,240,238,9,170,30,149,181,170,243,130,58,206,136,39,159,172,132,94,77,84,210,224,38,163,15,204,10,242,136,25,167,118,10,215,251,204,134,199,191,122,164,227,74,178,173,255,70,178,53,241,197,2,97,24,194,196,22,121,142,124,152,158,10,181,11,11,114,246,22,212,248,240,114,96,178,67,198,28,180,251,93,143,125,60,77,63,179,201,251,211,245,150,32,70,33,16,3,86,144,5,78,0,207,10,137,67,5,147,208,51,120,194,189,81,241,121,133,70,184,131,39,71,179,86,57,65,75,98,56,190,207,74,118,206,12,246,101,104,246,134,163,246,2,151,81,219,193,191,130,43,146,86,106,165,103,161,123,179,107,12,186,228,26,217,255,9,200,233,44,109,3,49,223,162,78,41,30,248,211,62,52,55,24,94,191,139,239,234,246,91,69,95,43,159,31,119,255,27,136,121,3,0,0 };
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


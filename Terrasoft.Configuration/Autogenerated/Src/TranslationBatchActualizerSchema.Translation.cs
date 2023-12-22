namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TranslationBatchActualizerSchema

	/// <exclude/>
	public class TranslationBatchActualizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TranslationBatchActualizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TranslationBatchActualizerSchema(TranslationBatchActualizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8fccbdb7-dc23-4a94-a151-19c141114606");
			Name = "TranslationBatchActualizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ab054f7f-9309-4520-a5a0-bfba22ceff76");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,84,193,74,195,64,16,61,111,161,255,176,208,75,10,37,31,208,34,69,43,66,64,161,104,193,163,108,147,105,186,144,236,150,217,73,64,139,255,238,38,27,99,98,178,213,131,7,115,218,204,188,121,111,223,203,16,37,114,48,39,17,3,223,1,162,48,250,64,225,70,171,131,76,11,20,36,181,10,119,40,148,201,234,243,116,114,158,78,88,97,164,74,249,211,171,33,200,87,237,123,119,28,161,59,101,49,22,53,67,72,237,11,223,100,194,152,37,239,244,111,4,197,199,235,152,10,145,201,55,192,26,125,42,246,153,140,121,92,129,47,96,121,143,168,203,193,206,53,207,151,172,86,134,176,136,73,163,85,223,214,244,14,209,72,249,69,130,168,211,219,162,46,101,98,149,105,88,91,84,116,140,69,54,154,77,145,81,129,16,169,131,110,39,204,104,121,193,187,244,247,58,77,251,228,174,50,119,212,75,190,23,6,130,49,109,47,253,144,139,87,95,145,189,255,218,254,35,24,93,96,12,173,19,252,86,232,123,248,23,17,13,175,248,151,161,205,64,37,110,177,250,91,102,9,78,128,36,161,218,49,212,4,49,65,210,228,140,178,20,4,131,160,91,239,47,228,233,172,220,120,195,230,39,240,54,234,155,179,20,168,57,49,4,235,88,249,21,249,122,237,128,44,240,99,174,120,224,83,156,143,108,195,188,182,81,5,248,99,138,15,64,71,157,140,69,248,153,129,46,237,223,198,178,242,82,203,132,71,138,0,149,200,218,157,237,200,7,183,54,244,157,204,193,46,173,72,238,80,231,205,151,100,213,154,132,23,71,219,9,119,117,159,219,240,25,37,193,247,46,152,192,205,141,155,117,213,126,177,174,117,158,15,137,111,121,229,156,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8fccbdb7-dc23-4a94-a151-19c141114606"));
		}

		#endregion

	}

	#endregion

}


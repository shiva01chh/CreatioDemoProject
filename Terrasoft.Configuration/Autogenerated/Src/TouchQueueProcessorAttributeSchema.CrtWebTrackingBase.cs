namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TouchQueueProcessorAttributeSchema

	/// <exclude/>
	public class TouchQueueProcessorAttributeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TouchQueueProcessorAttributeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TouchQueueProcessorAttributeSchema(TouchQueueProcessorAttributeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e9dc9ea7-5170-4749-8f69-4d60ffecdb57");
			Name = "TouchQueueProcessorAttribute";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d23d224d-d671-416d-91d0-80132a374d7a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,80,177,110,194,48,16,157,177,148,127,56,209,133,46,241,14,180,82,197,15,128,72,167,170,195,97,46,198,82,98,135,59,123,64,85,255,189,118,2,25,24,186,249,189,123,126,239,238,121,236,73,6,52,4,13,49,163,132,54,214,187,224,91,103,19,99,116,193,87,234,167,82,139,36,206,91,56,222,36,82,191,169,84,102,94,152,108,30,195,174,67,145,53,52,33,153,203,33,81,162,61,7,67,34,129,63,98,100,119,74,145,70,189,214,26,182,146,250,30,249,246,126,199,179,2,98,128,51,181,206,151,87,54,130,107,113,130,188,154,160,37,24,30,150,96,74,90,253,176,211,79,126,91,33,194,78,2,24,166,246,109,57,173,91,207,41,75,208,69,249,53,19,159,197,125,53,195,6,217,82,148,122,60,233,245,59,75,135,116,234,156,153,82,255,61,17,214,240,156,150,191,151,230,126,167,182,200,159,167,194,10,28,57,165,254,0,251,98,217,101,124,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e9dc9ea7-5170-4749-8f69-4d60ffecdb57"));
		}

		#endregion

	}

	#endregion

}


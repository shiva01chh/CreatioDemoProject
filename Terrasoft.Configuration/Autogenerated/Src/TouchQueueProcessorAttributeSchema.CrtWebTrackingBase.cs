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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,80,65,110,194,48,16,60,19,41,127,88,209,11,92,226,59,5,164,138,15,128,26,78,85,15,139,217,184,150,18,59,236,218,7,84,241,247,218,9,68,136,67,125,242,140,199,51,187,227,176,35,233,81,19,212,196,140,226,155,80,237,188,107,172,137,140,193,122,87,22,191,101,49,139,98,157,129,207,171,4,234,222,203,34,49,111,76,38,61,195,174,69,145,21,212,62,234,159,67,164,72,123,246,154,68,60,127,132,192,246,20,3,13,122,165,20,172,37,118,29,242,117,123,199,147,2,130,135,51,53,214,229,91,50,130,75,118,130,52,154,160,33,232,31,150,160,115,90,245,176,83,47,126,107,33,194,86,60,104,166,102,51,31,199,173,166,148,57,168,172,252,154,136,99,118,95,76,176,70,54,20,164,26,86,90,126,39,105,31,79,173,213,99,234,191,43,194,10,94,211,210,247,220,220,109,108,139,220,121,44,44,195,129,123,58,127,169,160,163,53,133,1,0,0 };
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


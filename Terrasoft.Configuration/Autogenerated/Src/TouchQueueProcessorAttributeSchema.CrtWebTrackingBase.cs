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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,80,49,142,194,48,16,172,137,148,63,172,160,129,38,238,129,59,9,241,129,59,93,168,78,87,44,102,99,44,37,118,110,215,46,16,226,239,216,9,164,160,192,149,103,60,158,217,29,135,29,73,143,154,160,38,102,20,223,132,106,239,93,99,77,100,12,214,187,178,184,150,197,44,138,117,6,126,46,18,168,219,148,69,98,22,76,38,61,195,190,69,145,53,212,62,234,243,119,164,72,95,236,53,137,120,222,133,192,246,24,3,13,122,165,20,108,37,118,29,242,229,243,129,39,5,4,15,39,106,172,203,183,100,4,255,217,9,210,104,130,134,160,127,90,130,206,105,213,211,78,189,248,109,133,8,91,241,160,153,154,143,249,56,110,53,165,204,65,101,229,239,68,28,178,251,114,130,53,178,161,32,213,176,210,234,47,73,251,120,108,173,30,83,223,174,8,107,120,77,75,223,115,115,183,177,45,114,167,177,176,12,7,46,157,59,101,244,221,24,125,1,0,0 };
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


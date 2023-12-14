namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITranslationLoggerSchema

	/// <exclude/>
	public class ITranslationLoggerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITranslationLoggerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITranslationLoggerSchema(ITranslationLoggerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fee74088-6ba4-462a-9370-fec3c8e1fb8d");
			Name = "ITranslationLogger";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5bb0d1bd-fb48-4884-8a1c-84058bcf48c3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,65,10,194,48,16,69,215,22,188,195,128,27,221,244,0,237,74,196,69,65,65,212,11,196,116,26,35,109,166,76,82,81,196,187,155,78,81,170,152,77,242,231,191,249,147,196,169,6,125,171,52,194,17,153,149,167,42,164,43,114,149,53,29,171,96,201,165,71,86,206,215,114,158,38,143,105,50,233,188,117,6,14,119,31,176,201,63,122,220,206,56,238,138,76,164,102,140,38,10,40,92,64,174,226,192,12,138,17,180,33,99,144,133,108,187,83,109,53,216,55,248,151,155,60,132,253,196,110,49,156,169,244,25,236,164,123,48,175,100,75,88,51,19,207,215,55,141,109,31,0,184,200,127,188,98,169,123,103,143,190,171,3,176,108,35,168,112,21,205,233,116,65,29,32,126,150,87,70,34,100,58,186,114,184,128,232,231,240,210,175,162,212,250,245,2,114,170,70,215,106,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fee74088-6ba4-462a-9370-fec3c8e1fb8d"));
		}

		#endregion

	}

	#endregion

}


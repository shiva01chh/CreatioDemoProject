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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,65,10,194,48,16,69,215,21,122,135,1,55,186,241,0,118,37,226,162,160,32,234,5,98,58,141,145,154,41,147,84,148,226,221,77,167,88,170,152,77,242,231,191,249,147,196,169,27,250,90,105,132,19,50,43,79,101,88,172,201,149,214,52,172,130,37,183,56,177,114,190,146,115,58,105,211,73,210,120,235,12,28,159,62,224,45,27,244,184,157,113,220,21,153,72,77,25,77,20,144,187,128,92,198,129,75,200,71,208,150,140,65,22,178,110,206,149,213,96,63,224,95,46,105,133,29,98,119,24,46,84,248,37,236,165,187,55,239,100,11,216,48,19,207,54,15,141,117,23,0,56,207,126,188,124,165,59,231,128,190,169,2,176,108,35,40,119,37,205,232,124,69,29,32,126,150,87,70,34,100,58,186,162,191,128,232,87,255,210,175,162,212,226,122,3,205,236,18,68,105,1,0,0 };
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


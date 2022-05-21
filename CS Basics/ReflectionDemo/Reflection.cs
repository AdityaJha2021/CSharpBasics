using System;
using System.Windows.Forms;
using System.Reflection;

namespace ReflectionDemo
{
    public partial class Reflection : Form
    {
        public Reflection()
        {
            InitializeComponent();
        }

        private void btnDiscoverTypeInformation_Click(object sender, EventArgs e)
        {
            string TypeName = txtTypeName.Text;
            Type T = Type.GetType(TypeName);

            lstMethodName.Items.Clear();
            lstPropertiesName.Items.Clear();
            lstConstructorName.Items.Clear();

            MethodInfo[] methodInfos = T.GetMethods();
            foreach (MethodInfo method in methodInfos)
            {
                lstMethodName.Items.Add(method.Name + " | " + method.ReturnType.Name);
            }

            PropertyInfo[] propertyInfos = T.GetProperties();
            foreach (PropertyInfo prop in propertyInfos)
            {
                lstPropertiesName.Items.Add(prop.PropertyType.Name + " | " + prop.Name);
            }

            ConstructorInfo[] constructorInfos = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructorInfos)
            {
                lstConstructorName.Items.Add(constructor.ToString());
            }

        }
    }
}

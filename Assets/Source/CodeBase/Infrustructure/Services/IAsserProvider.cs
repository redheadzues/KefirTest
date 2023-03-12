using UnityEngine;

namespace Assets.Source.CodeBase.Infrustructure.Services
{
    public interface IAsserProvider : IService
    {
        GameObject Instantiate(string path);
        GameObject Instantiate(string path, Transform parent);
        GameObject Instantiate(string path, Vector3 point, Quaternion quaternion, Transform parrent);
    }
}
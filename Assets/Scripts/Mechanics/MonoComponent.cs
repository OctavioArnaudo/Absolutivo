using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class MonoComponent : MonoBehaviour
{
    private static MonoBehaviour _instance;

    public static MonoBehaviour Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindFirstObjectByType<MonoBehaviour>();
                if (_instance == null)
                {
                    GameObject singletonObject = new GameObject(typeof(MonoBehaviour).Name + " (Singleton)");
                    _instance = singletonObject.AddComponent<MonoBehaviour>();
                    DontDestroyOnLoad(singletonObject);
                }
            }
            return _instance;
        }
    }

    // -----------------------------------------------------------
    // Métodos de Inicialización
    // -----------------------------------------------------------

    /// <summary>
    /// Se llama una vez cuando el script se carga. Es el primer método que se ejecuta, incluso antes que Awake.
    /// Se usa principalmente para inicializar variables, pero no para interactuar con otros GameObjects.
    /// </summary>
    public virtual void OnAwake()
    {
    }
    protected virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
        OnAwake();
    }

    /// <summary>
    /// Se llama una vez cuando el GameObject está activado. Es útil para lógica que necesita ejecutarse
    /// cada vez que el GameObject se activa, no solo al inicio.
    /// </summary>
    public virtual void Enable()
    {
    }
    protected virtual void OnEnable()
    {
        Enable();
    }

    // -----------------------------------------------------------
    // Métodos de Actualización
    // -----------------------------------------------------------

    public static List<Func<GameObject, GameObject>> OnGlobalObjectDetecting = new();
    protected List<Func<GameObject, GameObject>> OnObjectDetecting = new();
    public static List<Func<GameObject, GameObject>> OnGlobalDetecting = new();
    protected List<Func<GameObject, GameObject>> OnDetecting = new();

    public static event Func<GameObject, GameObject> OnGlobalObjectDetected;
    protected event Func<GameObject, GameObject> OnObjectDetected;    
    public static Func<GameObject, GameObject> OnGlobalDetected => null;
    protected virtual Func<GameObject, GameObject> OnDetected => null;

    public static UnityEvent<GameObject> OnGlobalObjectInspected = new();
    protected UnityEvent<GameObject> OnObjectInspected = new();
    public static event Action<GameObject> OnGlobalObjectProcessed;
    protected event Action<GameObject> OnObjectProcessed;
    public static UnityEvent<GameObject> OnGlobalInspected => null;
    protected virtual UnityEvent<GameObject> OnInspected => null;
    public static Action<GameObject> OnGlobalProcessed => null;
    protected virtual Action<GameObject> OnProcessed => null;

    public void Add<T>(ref List<Func<T, T>> e, List<Func<T, T>> m)
    {
        e.AddRange(m);
    }
    public void Add<T>(ref List<Func<T, T>> e, Func<T, T> m)
    {
        e.Add(m);
    }
    public void Add<T>(ref Func<T, T> e, Func<T, T> m)
    {
        e += m;
    }
    public void Add<T>(ref Action<T> e, Action<T> m)
    {
        e += m;
    }
    public void Add<T>(ref UnityEvent<T> e, UnityAction<T> m)
    {
        e.AddListener(m);
    }

    public void Remove<T>(ref List<Func<T, T>> e, List<Func<T, T>> m)
    {
        e.Remove(m.Last());
    }
    public void Remove<T>(ref List<Func<T, T>> e, Func<T, T> m)
    {
        e.Remove(m);
    }
    public void Remove<T>(ref Func<T, T> e, Func<T, T> m)
    {
        e -= m;
    }
    public void Remove<T>(ref Action<T> e, Action<T> m)
    {
        e -= m;
    }
    public void Remove<T>(ref UnityEvent<T> e, UnityAction<T> m)
    {
        e.RemoveListener(m);
    }

    public void Clear()
    {
        OnGlobalObjectDetecting.Clear();
        OnGlobalDetecting.Clear();
        OnGlobalObjectDetected = null;
        OnGlobalObjectProcessed = null;
        OnGlobalObjectInspected.RemoveAllListeners();
        OnGlobalInspected.RemoveAllListeners();
    }
    protected void RemoveAllListeners()
    {
        OnObjectDetecting.Clear();
        OnDetecting.Clear();
        OnObjectDetected = null;
        OnObjectProcessed = null;
        OnObjectInspected.RemoveAllListeners();
        OnInspected.RemoveAllListeners();
    }

    public static bool GlobalAutoSubscribe => true;
    protected virtual bool AutoSubscribe => true;

    public virtual void OnStart()
    {
        if (OnGlobalDetecting != null && GlobalAutoSubscribe)
        {
            Add(ref OnGlobalObjectDetecting, OnGlobalDetecting);
        }
        if (OnDetecting != null && AutoSubscribe)
        {
            Add(ref OnObjectDetecting, OnDetecting);
        }

        if (GlobalAutoSubscribe && OnDetecting.Count > 0)
        {
            foreach (var func in OnDetecting)
            {
                if (!OnGlobalObjectDetecting.Contains(func))
                    Add(ref OnGlobalObjectDetecting, func);
            }
        }
        if (AutoSubscribe && OnGlobalDetecting.Count > 0)
        {
            foreach (var func in OnGlobalDetecting)
            {
                if (!OnObjectDetecting.Contains(func))
                    Add(ref OnObjectDetecting, func);
            }
        }

        if (OnGlobalDetected != null && GlobalAutoSubscribe)
        {
            Add(ref OnGlobalObjectDetected, OnGlobalDetected);
        }
        if (OnDetected != null && AutoSubscribe)
        {
            Add(ref OnObjectDetected, OnDetected);
        }

        if (OnGlobalDetected != null && AutoSubscribe)
        {
            Add(ref OnObjectDetected, OnGlobalDetected);
        }
        if (OnDetected != null && GlobalAutoSubscribe)
        {
            Add(ref OnGlobalObjectDetected, OnDetected);
        }

        if (OnGlobalProcessed != null && GlobalAutoSubscribe)
        {
            Add(ref OnGlobalObjectProcessed, OnGlobalProcessed);
        }
        if (OnProcessed != null && AutoSubscribe)
        {
            Add(ref OnObjectProcessed, OnProcessed);
        }

        if (OnGlobalProcessed != null && AutoSubscribe)
        {
            Add(ref OnObjectProcessed, OnGlobalProcessed);
        }
        if (OnProcessed != null && GlobalAutoSubscribe)
        {
            Add(ref OnGlobalObjectProcessed, OnProcessed);
        }

        if (OnGlobalInspected != null && GlobalAutoSubscribe)
        {
            Add(ref OnGlobalObjectInspected, obj => OnGlobalInspected.Invoke(obj));
        }
        if (OnInspected != null && GlobalAutoSubscribe)
        {
            Add(ref OnObjectInspected, obj => OnInspected.Invoke(obj));
        }

        if (OnGlobalInspected != null && AutoSubscribe)
        {
            Add(ref OnObjectInspected, obj => OnGlobalInspected.Invoke(obj));
        }
        if (OnInspected != null && GlobalAutoSubscribe)
        {
            Add(ref OnGlobalObjectInspected, obj => OnInspected.Invoke(obj));
        }
    }
    /// <summary>
    /// Se llama una vez después de Awake. Es ideal para inicializar referencias a otros componentes o GameObjects,
    /// ya que para este momento, todos los GameObjects y sus scripts ya han ejecutado su Awake.
    /// </summary>
    protected virtual void Start()
    {
        OnStart();
    }

    /// <summary>
    /// Se llama en cada fotograma. Es el lugar principal para la lógica del juego, como movimiento de personajes,
    /// detección de entrada del usuario o actualizaciones de estado.
    /// </summary>
    public virtual void OnUpdate()
    {
    }
    protected virtual void Update()
    {
        OnUpdate();
    }

    /// <summary>
    /// Se llama en cada fotograma después de que se ha ejecutado todo el código en Update. Es útil
    /// para la lógica que debe ocurrir después de que se han completado todas las actualizaciones de posición,
    /// como la lógica de cámaras o de seguimiento.
    /// </summary>
    public virtual void OnLateUpdate()
    {
    }
    protected virtual void LateUpdate()
    {
        OnLateUpdate();
    }

    /// <summary>
    /// Se llama en un intervalo de tiempo fijo, independientemente de los fotogramas. Se usa para
    /// física (Physics), como la manipulación de Rigidbodies.
    /// </summary>
    public virtual void OnFixedUpdate()
    {
    }
    protected virtual void FixedUpdate()
    {
        OnFixedUpdate();
    }

    // -----------------------------------------------------------
    // Métodos de Detección de Colisiones
    // -----------------------------------------------------------

    /// <summary>
    /// Se llama en el primer fotograma en que el Collider del GameObject entra en contacto con otro Collider.
    /// </summary>
    /// <param name="collision">Información de la colisión.</param>
    public virtual void CollisionEnter(Collision collision)
    {
    }
    protected virtual void OnCollisionEnter(Collision collision)
    {
        CollisionEnter(collision);
    }

    /// <summary>
    /// Se llama en cada fotograma en que el Collider del GameObject está en contacto con otro Collider.
    /// </summary>
    /// <param name="collision">Información de la colisión.</param>
    public virtual void CollisionStay(Collision collision)
    {
    }
    protected virtual void OnCollisionStay(Collision collision)
    {
        CollisionStay(collision);
    }

    /// <summary>
    /// Se llama en el último fotograma en que el Collider del GameObject estaba en contacto con otro Collider.
    /// </summary>
    /// <param name="collision">Información de la colisión.</param>
    public virtual void CollisionExit(Collision collision)
    {
    }
    protected virtual void OnCollisionExit(Collision collision)
    {
        CollisionExit(collision);
    }

    // -----------------------------------------------------------
    // Métodos de Destrucción y Desactivación
    // -----------------------------------------------------------

    /// <summary>
    /// Se llama cuando el GameObject se desactiva. Es el opuesto de OnEnable.
    /// </summary>
    public virtual void Disable()
    {
    }
    protected virtual void OnDisable()
    {
        Disable();
    }

    public virtual void Destroy()
    {
        if (OnGlobalDetecting != null)
        {
            Remove(ref OnGlobalObjectDetecting, OnGlobalDetecting);
        }
        if (OnDetecting != null)
        {
            Remove(ref OnObjectDetecting, OnDetecting);
        }

        if (GlobalAutoSubscribe && OnDetecting.Count > 0)
        {
            foreach (var func in OnDetecting)
            {
                if (!OnGlobalObjectDetecting.Contains(func))
                    Remove(ref OnGlobalObjectDetecting, func);
            }
        }
        if (AutoSubscribe && OnGlobalDetecting.Count > 0)
        {
            foreach (var func in OnGlobalDetecting)
            {
                if (!OnObjectDetecting.Contains(func))
                    Remove(ref OnObjectDetecting, func);
            }
        }

        if (OnGlobalDetected != null)
        {
            Remove(ref OnGlobalObjectDetected, OnGlobalDetected);
        }
        if (OnDetected != null)
        {
            Remove(ref OnObjectDetected, OnDetected);
        }

        if (OnGlobalDetected != null)
        {
            Remove(ref OnObjectDetected, OnGlobalDetected);
        }
        if (OnDetected != null)
        {
            Remove(ref OnGlobalObjectDetected, OnDetected);
        }

        if (OnGlobalProcessed != null)
        {
            Remove(ref OnGlobalObjectProcessed, OnGlobalProcessed);
        }
        if (OnProcessed != null)
        {
            Remove(ref OnObjectProcessed, OnProcessed);
        }

        if (OnGlobalProcessed != null)
        {
            Remove(ref OnObjectProcessed, OnGlobalProcessed);
        }
        if (OnProcessed != null)
        {
            Remove(ref OnGlobalObjectProcessed, OnProcessed);
        }

        if (OnGlobalInspected != null)
        {
            Remove(ref OnGlobalObjectInspected, obj => OnGlobalInspected.Invoke(obj));
        }
        if (OnInspected != null)
        {
            Remove(ref OnObjectInspected, obj => OnInspected.Invoke(obj));
        }

        if (OnGlobalInspected != null)
        {
            Remove(ref OnObjectInspected, obj => OnGlobalInspected.Invoke(obj));
        }
        if (OnInspected != null)
        {
            Remove(ref OnGlobalObjectInspected, obj => OnInspected.Invoke(obj));
        }
    }
    /// <summary>
    /// Se llama cuando el script o GameObject se destruye. Es útil para limpiar recursos, como
    /// desuscribirse de eventos.
    /// </summary>
    protected virtual void OnDestroy()
    {
        Destroy();
    }

    public virtual void OnEnter2D(GameObject other)
    {
        GameObject obj;
        foreach (var globalObjectDetecting in OnGlobalObjectDetecting)
            obj = globalObjectDetecting(other);
        if (OnGlobalObjectDetected != null)
        {
            foreach (var handler in OnGlobalObjectDetected.GetInvocationList())
            {
                var func = handler as Func<GameObject, GameObject>;
                if (func != null)
                    obj = func(other);
            }
        }
        obj = OnGlobalObjectDetected?.Invoke(other);
        OnGlobalObjectProcessed?.Invoke(obj);
        OnGlobalObjectInspected?.Invoke(obj);
        if (OnObjectDetected != null)
        {
            foreach (var handler in OnObjectDetected.GetInvocationList())
            {
                var func = handler as Func<GameObject, GameObject>;
                if (func != null)
                    obj = func(other);
            }
        }
        obj = OnObjectDetected?.Invoke(other);
        OnObjectProcessed?.Invoke(obj);
        OnObjectInspected?.Invoke(obj);
    }
    public virtual void CollisionEnter2D(Collision2D collision)
    {
        OnEnter2D(collision.gameObject);
    }
    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        CollisionEnter2D(collision);
    }

    public virtual void TriggerEnter2D(Collider2D collider)
    {
        OnEnter2D(collider.gameObject);
    }
    protected virtual void OnTriggerEnter2D(Collider2D collider)
    {
        TriggerEnter2D(collider);
    }

    public virtual void CollisionExit2D(Collision2D collision)
    {
    }
    protected virtual void OnCollisionExit2D(Collision2D collision)
    {
        CollisionExit2D(collision);
    }

    public virtual void TriggerEnter(Collider collider)
    {
    }
    protected virtual void OnTriggerEnter(Collider collider)
    {
        TriggerEnter(collider);
    }

    public virtual void TriggerStay(Collider collider)
    {
    }
    protected virtual void OnTriggerStay(Collider collider)
    {
        TriggerStay(collider);
    }

    public virtual void TriggerExit(Collider collider)
    {
    }
    protected virtual void OnTriggerExit(Collider collider)
    {
        TriggerExit(collider);
    }
}
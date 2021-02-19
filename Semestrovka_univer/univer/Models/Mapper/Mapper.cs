using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace univer.Models.Mapper
{
    public abstract class Mapper <E,DTO>
    {
        protected Mapper()
        { }

        protected Mapper<E, DTO> _mapper;

        public abstract E MapToEntity(DTO dto);
        public abstract DTO MapToDTO(E e);

        public Mapper<E, DTO> GetInstance()
        {
            if (_mapper == null)
                _mapper = Initialize();

            return _mapper;
        }

        protected abstract Mapper<E, DTO> Initialize();
    }
}


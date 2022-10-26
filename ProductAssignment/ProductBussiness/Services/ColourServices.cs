using ProductData.Repository;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductBussiness.Services
{
    public class ColourServices
    {
        IColourRepo _colourRepo;
        public ColourServices(IColourRepo colourRepository)
        {
            _colourRepo = colourRepository;
        }
        public void AddColour(Colour colour)
        {
            _colourRepo.AddColour(colour);
        }
        public void UpdateColour(Colour colour)
        {
            _colourRepo.UpdateColour(colour);
        }
        public void DeleteColour(int colourId)
        {
            _colourRepo.DeleteColour(colourId);
        }

        public IEnumerable<Colour> GetColours()
        {
            return _colourRepo.GetColours();
        }
        public Colour GetColourByid(int colourId)
        {
            return _colourRepo.GetColourById(colourId);
        }
    }
}

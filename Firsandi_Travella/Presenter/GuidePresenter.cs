using Firsandi_Travella.Database;
using Firsandi_Travella.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firsandi_Travella.Interfaces;

namespace Firsandi_Travella.Presenter
{
           public class GuidePresenter
        {
            private readonly IGuideView _view;
            private readonly GuideRepository _repository;

            public GuidePresenter(IGuideView view)
            {
                _view = view;
                _repository = new GuideRepository();
            }

            public void LoadGuides()
            {
                var guides = _repository.GetGuides();
                _view.ShowGuides(guides);
            }

            public void UpdateGuide(GuideModels guide)
            {
                _repository.UpdateGuide(guide);
                LoadGuides(); // 🔥 Perbarui tampilan setelah update
            }

            public void DeleteGuide(int id)
            {
                _repository.DeleteGuide(id);
                LoadGuides(); // 🔥 Perbarui tampilan setelah hapus
            }
        }
}

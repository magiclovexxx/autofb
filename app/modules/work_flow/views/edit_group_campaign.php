<div class="row">
    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
        <div class="card">
            <div class="header">
                <h2>
                    <i class="fa fa-calendar-check-o" aria-hidden="true"></i> <?=l('Update group campaign')?> 
                </h2>
            </div>
            <div class="body pt0">
                <form action="<?=cn('update_group_campaign')?>" data-redirect="<?=cn('work_flow/manager_group')?>">
                    <div class="tab-content pt15">
                        <div role="tabpanel" class="tab-pane fade active in" id="home">
                            <input type="hidden" class="form-control" name="campaign_group_id" value="<?=!empty($result)?$result->id:""?>">
                            <div class="row">
                                <div class="col-sm-12 mb0">
                                    <b><?=l('Tên')?> (<span class="col-red">*</span>)</b>
                                    <div class="form-group">
                                        <div class="form-line">
                                            <input type="text" class="form-control" name="name" placeholder="Tên" value="<?=!empty($result)?$result->name:""?>">
                                        </div>
                                    </div>
                                    <label><?=l('Mô tả')?></label>
                                    <div class="form-group">
                                        <div class="form-line p5">
                                            <textarea rows="4" class="form-control post-message" name="description" placeholder="<?=l('Mô tả')?>" value="<?=!empty($result)?$result->description:""?>"></textarea>
                                        </div>
                                    </div>
                                    <div class="row">
                                      <div class="col-md-6">
                                          <b><i class="fa fa-calendar" aria-hidden="true"></i> <?=l('Ngày bắt đầu')?></b>
                                          <div class="input-group mb0">
                                              <div class="form-line">
                                                  <input type="text" name="start_date" class="form-control form-datetime" value="<?=!empty($result)?$result->start_date:""?>">
                                              </div>
                                          </div>
                                      </div>
                                      <div class="col-md-6 col-xs-6">
                                          <b><i class="fa fa-calendar" aria-hidden="true"></i> <?=l('Ngày kết thúc')?></b>
                                          <div class="input-group mb0">
                                              <div class="form-line">
                                                  <input type="text" name="end_date" class="form-control form-datetime" value="<?=!empty($result)?$result->end_date:""?>">
                                              </div>
                                          </div>
                                      </div>
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div> 
                    <button type="submit" class="btn bg-red waves-effect btnActionUpdate"><?=l('Submit')?></button>
                </form>
            </div>
        </div>
    </div>
</div>
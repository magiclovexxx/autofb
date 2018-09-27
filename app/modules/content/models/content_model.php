<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class content_model extends MY_Model {
	public function __construct(){
		parent::__construct();
	}

	public function getAllAccount(){
		$cate   = $this->model->get("*", CATEGORIES, "id = '".session("category")."' AND category = 'message'");
		$result = $this->model->fetch("*", FACEBOOK_ACCOUNTS, "status = 1".getDatabyUser(), "id", "asc");
		if(!empty($result)){
			foreach ($result as $key => $row) {
				$this->db->select("*");
				$this->db->where("account_id = '".$row->id."'");
				$this->db->where("type = 'friend'");

				if(session("category") && !empty($cate)){
					$group_id = json_decode($cate->data);
					if(!empty($group_id)){
						$this->db->where_in("pid", $group_id);
					}
				}
				
				if(IS_ADMIN != 1){
					$this->db->where("uid = '".session("uid")."'");
				}
				$this->db->order_by("type", "desc");
				$query = $this->db->get(FACEBOOK_GROUPS);
				$result[$key]->groups = $query->result();
			}
		}

		return $result;
	}
	
		public function getAllAccountlike(){
		 
	//	    $sIndexColumn = "id";
 
        /* Total data set length */
    //    $sQuery = "SELECT COUNT('" . $sIndexColumn . "') AS row_count
    //        FROM save_data";
    //        
    //    $rResultTotal = $this->db->query($sQuery);
    //    $aResultTotal = $rResultTotal->row();
    //    $iTotal = $aResultTotal->row_count;
	//	
	//	$iDisplayStart = $this->input->get_post('start', true);
    //    $iDisplayLength = $this->input->get_post('length', true);
        
      //  vardump($iDisplayStart); die();
        $this->db->select("*");
		//$this->db->where("account_id = '".$row->id."'");
       // $this->db->limit(5000);
            $query = $this->db->get(save_data);
		    return $query;
		}
		
		 public function get_books($start, $length, $order, $dir) 
   {

       if($order !=null) {
           $this->db->order_by($order, $dir);
       }

       return $this->db
           ->limit($length,$start)
           //->where ("cat_data= '".$category."'")
           ->get("save_data");
   }

   public function get_total_books() 
   {
       
        $sIndexColumn = "id";
 
        $sQuery = "SELECT COUNT('" . $sIndexColumn . "') AS row_count
            FROM save_data";
        $rResultTotal = $this->db->query($sQuery);
        $aResultTotal = $rResultTotal->row();
        $iTotal = $aResultTotal->row_count;
       // var_dump ($iTotal); die();
        if(!empty($iTotal)) return $iTotal;
        return 0;
   }
}
